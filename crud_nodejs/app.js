const express = require('express');
const app = express();

// Motor de plantilla
app.set('view engine', 'ejs')

// Llamanos a las rutas

app.use('/', require('./routes/router'))

app.listen(9999, ()=>{
    console.log('Server corriendo en el puerto 9999')
})

