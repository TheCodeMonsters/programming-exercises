const mysql = require('mysql2');

const conexion = mysql.createConnection({
  host: 'localhost',
  user: 'root',
  password: '',
  database: 'gastos',
});

conexion.connect((err, conn) => {
  if (err) {
    console.log('ha ocurrido un error en la conexion' + err);
  } else {
    console.log('se conecto correctamente a la base datos');
    return conn;
  }
});

module.exports = conexion;
