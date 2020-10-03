//Cai cac thu vien
//npm install body-parser express express-fileupload 
const express = require('express')
console.log(`express = ${express}`)
const app = express()
const MAXMUM_FILE_SIZE = 50
const bodyParser = require('body-parser')
const fileUpload = require('express-fileupload')

app.use(bodyParser.urlencoded({ extended: false }))
app.use(bodyParser.json())
app.use(fileUpload({
    limits: { fileSize: MAXMUM_FILE_SIZE * 1024 * 1024 },  //Maximum = 50 MB  
}))
PORT = 3000
app.listen(PORT, () => {
    console.log(`app listen from : ${PORT}`)    
})