const express = require('express');
const router = express.Router();

const conexion = require('../database/db');

// Creamos las rutas
router.get('/', (req, res) => {
    res.render('index');
    // conexion.query('SELECT * FROM users', (err, results) => {
    //     if (err) {
    //         throw err;
    //     } else {
    //         res.send(results);
    //     }
    // });
});

module.exports = router;
