import mysql.connector as mysql


def conectar():
    try:
        conexion = mysql.connect(
            host='127.0.0.1',
            user='root',
            password='',
            database='libro'
        )
        print('Se ha conectado a la base de datos')
        return conexion
    except mysql.Error as err:
        print('Ha ocurrido un error', err)
