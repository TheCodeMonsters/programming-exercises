import os
from conexion import *
from contacto import *
from tabulate import tabulate


con = conectar()
crear_tabla(con)

##############


def iniciar():

    os.system('cls')
    while True:
        print("Seleccione una opción: ")
        print("\t1. Añadir contacto")
        print("\t2. Mostrar todos los contactos")
        print("\t3. Buscar un contacto")
        print("\t4. Modificar Contacto")
        print("\t5. Eliminar contacto")
        print("\t6. Sarli")

        opcion = input('Escoja una opción')

        if opcion == '1':
            nuevo_contacto()
        elif opcion == '2':
            ver_contactos()
        elif opcion == '3':
            buscar_contacto()
        elif opcion == '4':
            modificar_contacto()
        elif opcion == '5':
            eliminar_contacto()
        elif opcion == '6':
            break


def nuevo_contacto():
    nombre = input('Ingrese el nombre')
    apellidos = input('Ingrese el apellido')
    empresa = input('Ingrese el empresa')
    telefono = input('Ingrese el telefono')
    email = input('Ingrese el email')
    direccion = input('Ingrese el direccion')

    respuesta = registrar(nombre, apellidos, empresa,
                          telefono, email, direccion)
    print(respuesta)

##############


def ver_contactos():
    datos = mostar()
    headers = ['ID', 'NOMBRE', 'APELLIDOS',
               'EMPRESA', 'TELEFONO', 'EMIAL', 'DIRECCIÓN']

    tabla = tabulate(datos, headers, tablefmt='fancy_grid')
    print(tabla)


################################
def buscar_contacto():
    id = input('Ingrese el id del contacto')
    datos = buscar(id)
    headers = ['ID', 'NOMBRE', 'APELLIDOS',
               'EMPRESA', 'TELEFONO', 'EMIAL', 'DIRECCIÓN']

    tabla = tabulate(datos, headers, tablefmt='fancy_grid')
    print(tabla)

############################################


def modificar_contacto():
    id = input('Ingrese el id del contacto a modificar')
    nombre = input('Ingrese el nombre')
    apellidos = input('Ingrese el apellido')
    empresa = input('Ingrese el empresa')
    telefono = input('Ingrese el telefono')
    email = input('Ingrese el email')
    direccion = input('Ingrese el direccion')

    respuesta = modificar(id, nombre, apellidos, empresa,
                          telefono, email, direccion)
    print(respuesta)

##############


def eliminar_contacto():
    id = input('Ingrese el id del contacto a eliminar')
    respuesta = eliminar(id)
    print(respuesta)


iniciar()
