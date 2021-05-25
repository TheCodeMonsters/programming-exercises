from conexion import *


def registrar(nombre, apellidos, empresa, telefono, email, direccion):
    try:
        con = conectar()
        cursor = con.cursor()
        sentencia_sql = ''' INSERT INTO contacto(nombre, apellidos, empresa, telefono, email, direccion)
                            values(?, ?, ?, ?, ?, ?)  '''

        datos = (nombre, apellidos, empresa, telefono,
                 email, direccion)  # Tupla de datos
        # Ejecutamos la sentencia sql con cursor
        cursor.execute(sentencia_sql, datos)
        con.commit()  # Hacemos una actualización con commit
        con.close()  # Cerramos la conexion
        return 'Registro correcto'
    # Todo eso es si no sale un error, lo que sigue es por si sale un error
    except sqlite3.Error as err:
        print('Ha ocurrido un error', err)


def mostar():
    datos = []
    try:
        con = conectar()
        cursor = con.cursor()
        sentencia_sql = ''' SELECT * FROM contactos '''
        cursor.execute(sentencia_sql)
        datos = cursor.fetchall()  # aca se biene toda la consulta
        con.close()
    except sqlite3.Error as err:
        print('Ha ocurrido un error')
