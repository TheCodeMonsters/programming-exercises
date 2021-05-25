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
        sentencia_sql = " SELECT * FROM libros WHERE id=%s "
        cursor.execute(sentencia_sql, (id,))
        datos = cursor.fetchall()
        con.close()
    except mysql.Error as err:
        print('Ha ocurrido un eror', err)
    return datos


def modificar(id, campo, nuevo_valor):
    try:
        sentencia_sql = ''
        con = conectar()
        cursor = con.cursor()
        if campo == '1':
            sentencia_sql = ''' UPDATE libros SET titulo=%s WHERE id=%s '''
        elif campo == '2':
            sentencia_sql = ''' UPDATE libros SET author=%s WHERE id=%s '''
        elif campo == '3':
            sentencia_sql = ''' UPDATE libros SET estado=%s  WHERE id=%s '''

        datos = (nuevo_valor, id)
        cursor.execute(sentencia_sql, datos)
        con.commit()
        con.close()
        return 'Se actualizó correctamente'
    except mysql.Error as err:
        print('Ha ocurrido un error', err)


def eliminar(id):
    try:
        con = conectar()
        cursor = con.cursor()
        sentencia_sql = ''' DELETE FROM libros WHERE id=%s '''
        cursor.execute(sentencia_sql, (id,))
        con.commit()
        con.close()
        return 'Se elimino correctamente'
    except mysql.Error as err:
        print('Ha ocurrido un error', err)
