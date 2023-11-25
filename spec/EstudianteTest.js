describe("Estudiante", function(){
    var course;
    var student1, student2;
    var alta;

    beforeAll(function(){
        course = new Curso(1, "Git", "Version control system");
        student1 = new Estudiante("John Lee", 18);
        student2 = new Estudiante("Tom Bee", 19);
    });

    beforeEach(function(){
        course.students = [];
    });

    it("Ralizar alta", function(){
        student1.realizarAlta();
        expect(student1.alta).toEqual(1);
    });

});

