import mysqlx

from conexion import *


def registrar(titulo, author, estado):
    try:
        con = conectar()
        cursor = con.cursor()
        sentencia_sql = ''' INSERT INTO libros (titulo, author, estado) VALUES (%s, %s, %s) '''  # %s dice que vamos a psar String
        datos = (titulo, author, estado)  # tupla de los datos
        cursor.execute(sentencia_sql, datos)
        con.commit()
        con.close()

        return 'Se registro con exito'
    except mysql.Error as err:
        print('Ha ocurrido un error', err)


def mostar():
    datos = []
    try:
        con = conectar()
        cursor = con.cursor()
        sentencia_sql = " SELECT * FROM libros "
        cursor.execute(sentencia_sql)
        datos = cursor.fetchall()
        con.close()
    except mysql.Error as err:
        print('Ha ocurrido un eror')
    return datos


def buscar(id):
    datos = []
    try:
        con = conectar()
        cursor = con.cursor()
        sentencia_sql = " SELECT * FROM libros HWERE id=%s "
        cursor.execute(sentencia_sql)
        datos = cursor.fetchall()
        con.close()
    except mysql.Error as err:
        print('Ha ocurrido un eror')
    return datos
