def ejer1(): #Creando metodo ejer1
    nombre = input("Ingrese su nombreP: ")
    carrera = input("Ingrese su carrera: ")

    print(f"\n{nombre}, bienvenido a FA de {carrera}")
def ejer2():
    print("\"Eduardo\"")

def ejer3():
      x = int(input("Ingrese el valor de x: "))
      y = int(input("ingrese el valor de y: "))

      print("Suma: ", (x+y))
      print("Resta: ", (x-y))
      print("Multiplicacion: ", (x*y))
      print("Division: ", (x/y))

import math #Importando la libreria math

def ejer4():
    num = float(input("Ingrese un número decimal: "))

    print("Raiz 2: ", math.sqrt(num))
    print("redondeado: ", round(num,0))
    print("al cubo: ", math.pow(num,3))
    print("raiz 3: ", num ** (1/3))


def ejer5():
    num = input("Ingrese numero: ")

entero = int(num)
deci = float(num)

print("Resto: ", (entero%2))
print("Division: ", (deci/3))

ejer5()
    