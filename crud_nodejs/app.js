const express = require('express');
const app = express();

// Establecer el motor de vista en ejs
app.set('view engine', 'ejs')

// Llamanos a las rutas
app.use('/', require('./routes/router'))



// Ponemos el puerto donde se va ejecutar el servidor
app.listen(9999, () => {
    console.log('Server corriendo en el puerto 9999')
})

