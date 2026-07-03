using System;
namespace HashGen {
    class Program {
        static void Main() {
            Console.WriteLine(BCrypt.Net.BCrypt.HashPassword("password-123"));
        }
    }
}
