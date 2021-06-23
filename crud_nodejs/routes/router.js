const express = require('express');
const router = express.Router();

const conexion = require('../database/db');

// Creamos las rutas

// Mostrar los registros
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

// Crear registros

router.get('/create', (req, res)=>{
    res.render('pages/create')
})

module.exports = router;
