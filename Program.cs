
// EJERCICIOS POO 1

using ComIT.Console;

Libro libro1 = new();

Libro libro2 = new("El Color Que Cayó del Cielo", "H.P. Lovecraft", 5, 2);

// Verificar datos del libro 1 generados correctamente
libro1.Datos();

// Verificar datos del libro 2 generados correctamente
libro2.Datos();

// Verificar datos del libro 2 actualizados correctamente
libro2.Prestar();
libro2.Datos();

// Verificar datos del libro 2 actualizados correctamente
libro2.Devolver();
libro2.Datos();