#include <iostream>
#include <cmath>

// Definición de nodo para la lista enlazada
struct Nodo {
    int dato;
    Nodo* siguiente;
};

// Función para agregar un nodo al final de la lista
void agregarAlFinal(Nodo*& cabeza, int valor) {
    Nodo* nuevoNodo = new Nodo{valor, nullptr};
    if (cabeza == nullptr) {
        cabeza = nuevoNodo;
    } else {
        Nodo* temp = cabeza;
        while (temp->siguiente != nullptr) {
            temp = temp->siguiente;
        }
        temp->siguiente = nuevoNodo;
    }
}

// Función para agregar un nodo al inicio de la lista
void agregarAlInicio(Nodo*& cabeza, int valor) {
    Nodo* nuevoNodo = new Nodo{valor, cabeza};
    cabeza = nuevoNodo;
}

// Función para verificar si un número es primo
bool esPrimo(int num) {
    if (num <= 1) return false;
    for (int i = 2; i <= std::sqrt(num); ++i) {
        if (num % i == 0) return false;
    }
    return true;
}

// Función para verificar si un número es Armstrong
bool esArmstrong(int num) {
    int suma = 0, temp = num, n = 0;
    // Contar la cantidad de dígitos
    while (temp != 0) {
        ++n;
        temp /= 10;
    }
    temp = num;
    // Sumar las potencias de los dígitos
    while (temp != 0) {
        int digito = temp % 10;
        suma += std::pow(digito, n);
        temp /= 10;
    }
    return suma == num;
}

// Función para contar los elementos de una lista
int contarElementos(Nodo* cabeza) {
    int contador = 0;
    while (cabeza != nullptr) {
        ++contador;
        cabeza = cabeza->siguiente;
    }
    return contador;
}

// Función para mostrar los elementos de una lista
void mostrarLista(Nodo* cabeza) {
    while (cabeza != nullptr) {
        std::cout << cabeza->dato << " ";
        cabeza = cabeza->siguiente;
    }
    std::cout << std::endl;
}

int main() {
    Nodo* listaPrimos = nullptr;
    Nodo* listaArmstrong = nullptr;

    int num;
    char opcion;

    do {
        std::cout << "Ingrese un número: ";
        std::cin >> num;

        if (esPrimo(num)) {
            agregarAlFinal(listaPrimos, num);
        }
        if (esArmstrong(num)) {
            agregarAlInicio(listaArmstrong, num);
        }

        std::cout << "¿Desea ingresar otro número? (s/n): ";
        std::cin >> opcion;
    } while (opcion == 's' || opcion == 'S');

    int cantidadPrimos = contarElementos(listaPrimos);
    int cantidadArmstrong = contarElementos(listaArmstrong);

    std::cout << "\nNúmero de datos en la lista de primos: " << cantidadPrimos << std::endl;
    std::cout << "Número de datos en la lista de Armstrong: " << cantidadArmstrong << std::endl;

    if (cantidadPrimos > cantidadArmstrong) {
        std::cout << "La lista de primos contiene más elementos." << std::endl;
    } else if (cantidadArmstrong > cantidadPrimos) {
        std::cout << "La lista de Armstrong contiene más elementos." << std::endl;
    } else {
        std::cout << "Ambas listas contienen la misma cantidad de elementos." << std::endl;
    }

    std::cout << "\nDatos en la lista de primos:" << std::endl;
    mostrarLista(listaPrimos);

    std::cout << "\nDatos en la lista de Armstrong:" << std::endl;
    mostrarLista(listaArmstrong);

    // Liberar la memoria utilizada por las listas
    while (listaPrimos != nullptr) {
        Nodo* temp = listaPrimos;
        listaPrimos = listaPrimos->siguiente;
        delete temp;
    }
    while (listaArmstrong != nullptr) {
        Nodo* temp = listaArmstrong;
        listaArmstrong = listaArmstrong->siguiente;
        delete temp;
    }

    return 0;
}
