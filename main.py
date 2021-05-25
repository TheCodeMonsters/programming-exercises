import os
from conexion import *
from contacto import *
from tabulate import tabulate


con = conectar()
crear_tabla(con)


def iniciar():
    os.system('cls')
    print("Seleccione una opción: ")
    print("\t1. Añadir contacto")
    print("\t2. Mostrar todos los contactos")
    print("\t3. Buscar un contacto")
    print("\t4. Modificar Contacto")
    print("\t5. Eliminar contacto")
    print("\t6. Añadir contacto")
    opcion = input('Escoja una opción')

    if opcion == '1':
        nuevo_contacto()
    elif opcion == '2':
        ver_contactos()


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


def ver_contactos():
    datos = mostar()
    headers = ['ID', 'NOMBRE', 'APELLIDOS',
               'EMPRESA', 'TELEFONO', 'EMIAL', 'DIRECCIÓN']

    tabla = tabulate(datos, headers, tablefmt='fancy_grid')
    print(tabla)


iniciar()
