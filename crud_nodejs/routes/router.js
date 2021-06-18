const express = require('express');
const router = express.Router();

const conexion = require('../database/db');

// Creamos las rutas
router.get('/', (req, res) => {
    conexion.query('SELECT * FROM users', (err, results) => {
        if (err) {
            throw err;
        } else {
            // Esto lo renderiza en el front
            res.render('index', {results:results});
        }
    });
});

module.exports = router;
