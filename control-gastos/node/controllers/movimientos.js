const conexion = require('./conexion');

const all = (req, res) => {
  const sql = 'select * from movimiento';
  conexion.query(sql, (err, result) => {
    if (err) {
      res.send('ha ocurrido un error' + err);
    } else {
      res.send(result);
    }
  });
};

const buscar = (req, res) => {
  const id = req.params.id;
  const sql = `slect * from movimiento where id=${id}`;
  conexion.query(sql, (err, result) => {
    if (err) {
      res.send('ha ocurrido un error' + err);
    } else {
      res.send(result);
    }
  });
};
