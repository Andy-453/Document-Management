using DocumentManagementBackend.Context;
using DocumentManagementBackend.Model;
using Microsoft.EntityFrameworkCore;

namespace DocumentManagementBackend.Repository
{
    public class UserRepository
    {
            private readonly DMDbContext _context;

            public UserRepository(DMDbContext context)
            {
                _context = context;
            }
        // Obtener todos los usuarios
        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _context.Users
                .Where(a => !a.IsDeleted)
                .ToListAsync();
        }
        public async Task<User> GetUserByIdAsync(int id)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                throw new KeyNotFoundException($"User with ID {id} not found.");
            }

            return user;
        }
        // Crear un nuevo usuario
        public async Task CreateUserAsync(User user)
        {

            // Hashear la contraseña antes de guardar el usuario
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

            // Verificar el hash de la contraseña en la consola
            Console.WriteLine("Password Hash: " + user.Password);

            // Agregar el nuevo registro de usuario
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

        }


        // Actualizar un usuario existente
        public async Task UpdateUserAsync(User user)
        {
            var existingUser = await _context.Users.FindAsync(user.Id);
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;

                // Solo actualizar la contraseña si se proporciona una nueva
                if (!string.IsNullOrEmpty(user.Password))
                {
                    existingUser.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
                }

                await _context.SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException($"User with ID {user.Id} not found.");
            }
        }

        // Eliminar un usuario
        public async Task DeleteUserAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                user.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        // Obtener un usuario por su correo electrónico para el inicio de sesión
        public async Task<User> GetUserByEmailAsync(string email)
        {
            var user = await _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.Email == email && !s.IsDeleted);

            // Manejo de errores: lanzar excepción si el usuario no se encuentra
            if (user == null)
            {
                throw new KeyNotFoundException($"No se encontró un usuario con el correo: {email}");
            }

            return user;
        }
    }
}
