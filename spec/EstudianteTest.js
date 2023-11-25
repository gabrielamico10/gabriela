describe("Estudiante", function(){
    var course;
    var student;
    var nota = 8;

    beforeAll(function(){
        course = new Curso(1, "Git", "Version control system");
        student = new Estudiante("John Lee", 18);
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
        student.agregarNota(nota);
        expect(student.notas).toEqual(jasmine.arrayContaining([nota]));
    });

    //Al eliminar una nota comprobar que no se encuentra en el array de notas.
    it("Remove a grade", function(){
        student.eliminarNota(nota);
        expect(student.notas).not.toEqual(jasmine.arrayContaining([nota]));
    });

    //Al calcular la media comprobar que si el array es de tamaño 0 la nota media es 0
    it("Calcular media", function(){
        var media = student.calcularMedia();
        expect(media).toEqual(0);
    });
});

