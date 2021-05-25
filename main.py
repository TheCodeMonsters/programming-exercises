import os
from conexion import *

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
    input('Escoja una opción')


iniciar()
