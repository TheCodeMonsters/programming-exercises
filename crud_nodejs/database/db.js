const mysql = require('mysql')

const conexion = mysql.createConnection({
    host: 'localhost',
    user: 'root',
    password: '',
    database: 'crud_nodejs_db'
})

// Verificamos la conexion a la base de datos

conexion.connect((error) => {
    if(error){
        console.error('El error de conexion es: ' + error);
        return
    }
    console.log('¡Conectado a la base de datos')
})

module.exports = conexion