function Estudiante(nombre,edad){
    this.nombre = nombre;
    this.edad = edad;
    this.alta = 1;
    this.notas =[];
}

Estudiante.prototype.enviarMensaje = function(texto){
    //Enviar mensaje de correo
    console.log("Enviando mensaje");
    return true;
}

Estudiante.prototype.realizarAlta = function(){
    if (this.alta == 0){
        this.alta = 1;
    }
}

Estudiante.prototype.realizarBaja = function(){
    if (this.alta == 1){
        this.alta = 0;
    }
}

Estudiante.prototype.agregarNota = function(nota){
    this.notas.push(nota);
}

Estudiante.prototype.eliminarNota = function(nota){
    this.notas.splice(this.notas.indexOf(nota),1);
}

Estudiante.prototype.calcularMedia = function(){
    if (this.notas.length>0){
        var acumula = 0;
        for (i = 0; i< this.notas.length;i++){
            acumula = acumula + this.notas[i].valor;
        }
        return (acumula/this.notas.length);
    }else{
        return 0;
    }
}