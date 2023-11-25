describe("Estudiante", function(){
    var course;
    var student;

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

});

