describe("Estudiante", function(){
    var student;
    var nota1;
    var nota2;

    beforeAll(function(){
        student = new Estudiante("John Lee", 18);
        nota1 = new Nota("Unidad1", 8);
        nota2 = new Nota("Unidad2", 9);
    });

    beforeEach(function(){
        student.notas = [];
    });

    // Al finalizar un alta comprobar que el atributo alta almacena el valor 1
    it("Ralizar alta", function(){
        student.realizarAlta();
        expect(student.alta).toEqual(1);
    });

    //Al finalizar una baja comprobar que el atributo baja almacena el valor 0
    it("Ralizar baja", function(){
        student.realizarBaja();
        expect(student.alta).toEqual(0);
    });

    //Al agregar una nota comprobar que se encuentra almacenada en el array de notas.
    it("Add a grade", function(){
        student.agregarNota(nota1);
        expect(student.notas).toEqual(jasmine.arrayContaining([nota1]));
    });

    //Al eliminar una nota comprobar que no se encuentra en el array de notas.
    it("Remove a grade", function(){
        student.eliminarNota(nota1);
        expect(student.notas).not.toEqual(jasmine.arrayContaining([nota1]));
    });

    //Al calcular la media comprobar que si el array es de tamaño 0 la nota media es 0
    it("Calcular media", function(){
        var media = student.calcularMedia();
        expect(media).toEqual(0);
    });

    //Al calcular la media de un estudiantes con los notas 8 y 9 para la Unidad 1 y Unidad 2 el valor obtenido es 8,5
    it("Calcular media II", function(){
        student.agregarNota(nota1);
        student.agregarNota(nota2);
        var media = student.calcularMedia();
        expect(media).toEqual(8.5);
    });
});

