#include <iostream>
#include <vector>
#include <numeric>  // Para std::accumulate

int main() {
    int n;
    std::cout << "Ingrese la cantidad de datos: ";
    std::cin >> n;

    // Crear una lista para almacenar los datos
    std::vector<double> datos(n);

    // Ingresar los datos en la lista principal
    std::cout << "Ingrese los datos:" << std::endl;
    for (int i = 0; i < n; ++i) {
        std::cin >> datos[i];
    }

    // Calcular el promedio
    double suma = std::accumulate(datos.begin(), datos.end(), 0.0);
    double promedio = suma / n;

    // Crear dos listas adicionales para clasificar los datos
    std::vector<double> menores_igual_promedio;
    std::vector<double> mayores_promedio;

    // Clasificar los datos según el promedio
    for (double dato : datos) {
        if (dato <= promedio) {
            menores_igual_promedio.push_back(dato);
        } else {
            mayores_promedio.push_back(dato);
        }
    }

    // Mostrar los resultados
    std::cout << "\nDatos cargados en la lista principal:" << std::endl;
    for (double dato : datos) {
        std::cout << dato << " ";
    }
    std::cout << std::endl;

    std::cout << "Promedio: " << promedio << std::endl;

    std::cout << "\nDatos menores o iguales al promedio:" << std::endl;
    for (double dato : menores_igual_promedio) {
        std::cout << dato << " ";
    }
    std::cout << std::endl;

    std::cout << "\nDatos mayores al promedio:" << std::endl;
    for (double dato : mayores_promedio) {
        std::cout << dato << " ";
    }
    std::cout << std::endl;

    return 0;
}
