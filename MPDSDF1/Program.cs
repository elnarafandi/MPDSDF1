using MPDSDF1.Task1;
using MPDSDF1.Task2;
using MPDSDF1.Task3;
using MPDSDF1.Task4;
using MPDSDF1.Task5;

#region Task1

//try
//{
//    Student student1 = new Student()
//    {
//        StudentId = 1,
//        Name = "Student1",
//        Email = "student1@gmail.com",
//        Scores = new List<int> { 65, 70, 92 }
//    };
//    Student student2 = new Student()
//    {
//        StudentId = 2,
//        Name = "Student2",
//        Email = "student2@gmail.com",
//        Scores = new List<int> { 50, 45, 83 }
//    };
//    Student student3 = new Student()
//    {
//        StudentId = 3,
//        Name = "Student3",
//        Email = "student3@gmail.com",
//        Scores = new List<int> { 87, 100, 79 }
//    };

//    List<Student> students = new List<Student>();
//    students.Add(student1);
//    students.Add(student2);
//    students.Add(student3);

//    students[1].AddScore(100);

//    foreach (Student student in students)
//    {
//        string info = $"Id: {student.StudentId} Name: {student.Name} Email: {student.Email} Scores: {string.Join(", ", student.Scores)} Average scor: {student.GetAverageScore()}";
//        Console.WriteLine(info);
//    }
//}
//catch (WrongFormatException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch(ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}

#endregion



#region Task2

//try
//{
//    ExamQuestion examQuestion1 = new MultipleChoiceQuestion()
//    {
//        QuestionId = 1,
//        QuestionText = "What is the largest planet in our solar system?",
//        Options = new string[] { "A) Earth", "B) Jupiter", "C) Saturn", "D) Mars" },
//        Marks = 5,
//        CorrectOption = 1
//    };
//    ExamQuestion examQuestion2 = new TrueFalseQuestion()
//    {
//        QuestionId = 2,
//        QuestionText = "The capital of Australia is Sydney.",
//        Marks = 9,
//        CorrectAnswer = false
//    };
//    ExamQuestion examQuestion3 = new MultipleChoiceQuestion()
//    {
//        QuestionId = 3,
//        QuestionText = "Who wrote the play \"Romeo and Juliet\"?",
//        Options = new string[] { "A) Charles Dickens", "B) Jane Austen", "C) William Shakespeare", "D) Mark Twain" },
//        Marks = 3,
//        CorrectOption = 2
//    };
//    ExamQuestion examQuestion4 = new TrueFalseQuestion()
//    {
//        QuestionId = 4,
//        QuestionText = "The Earth orbits the Sun.",
//        Marks = 2,
//        CorrectAnswer = true
//    };

//    List<ExamQuestion> questions = new List<ExamQuestion>();
//    questions.Add(examQuestion1);
//    questions.Add(examQuestion2);
//    questions.Add(examQuestion3);
//    questions.Add(examQuestion4);

//    int sumTotal = 0;
//    foreach (ExamQuestion question in questions)
//    {
//        int sum = 0;
//        question.DisplayQuestion();
//        string studentAnswer = Console.ReadLine();
//        sumTotal += question.TotalMark(studentAnswer);
//        sum += question.TotalMark(studentAnswer);
//        Console.WriteLine(sum);
//    }
//    Console.WriteLine(sumTotal);
//}
//catch(WrongFormatException ex)
//{
//    Console.WriteLine(ex.Message);
//}

#endregion



#region Task3

//try
//{
//    Exam exam1 = new OnlineExam()
//    {
//        ExamId = 1,
//        ExamDate = DateTime.Now,
//        Answers = new string[] { "A", "A", "C" }
//    };
//    Exam exam2 = new WrittenExam()
//    {
//        ExamId = 2,
//        ExamDate = DateTime.Now,
//        AnswerSheet = "Answer1, Answer2, Answer3"
//    };


//    ExamStudent student1 = new ExamStudent()
//    {
//        Name = "Student1"
//    };

//    List<Exam> exams = new List<Exam>();

//    exams.Add(exam1);
//    exams.Add(exam2);


//    foreach (var exam in exams)
//    {
//        exam.DisplayExam();

//        if (exam is IExamSubmission examSubmission)
//        {
//            examSubmission.SubmitExam(student1);
//            examSubmission.GradeExam(student1);   
//        }
//    }
//}
//catch(IndexOutOfRangeException ex)
//{
//    Console.WriteLine(ex.Message);
//}

#endregion



#region Task4

//try
//{
//    ExamSchedule examSchedule1 = new InPersonExamSchedule()
//    {
//        ExamId = 1,
//        ScheduledDate = new DateTime(2024, 10, 30),
//        RoomNumber = 112
//    };
//    ExamSchedule examSchedule2 = new OnlineExamSchedule()
//    {
//        ExamId = 2,
//        ScheduledDate = new DateTime(2024, 11, 8),
//        PlatformLink = "https://example.com/exam"
//    };

//    List<ExamSchedule> examSchedules = new List<ExamSchedule>();
//    examSchedules.Add(examSchedule1);
//    examSchedules.Add(examSchedule2);
//    foreach(var examSchedule in examSchedules)
//    {
//        examSchedule.ScheduleExam();
//    }


//}
//catch(ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}

#endregion



#region Task5

//try
//{
//    int[] classScores = { 80, 90, 100 };
//    int[][] studentAnswers =
//            {
//            new[] { 1, 1, 0, 1, 0 },
//            new[] { 1, 1, 1, 1, 0 },
//            new[] { 0, 0, 1, 0, 0 }
//        };
//    GradingStrategy standardGrading = new StandardGradingStrategy();
//    GradingStrategy curveGrading = new CurveGradingStrategy(classScores);
//    foreach (var answers in studentAnswers)
//    {
//        double standardScore = standardGrading.CalculateFinalScore(answers);
//        Console.WriteLine($"Standard Score: {standardScore}");

//        double curveScore = curveGrading.CalculateFinalScore(answers);
//        Console.WriteLine($"Curved Score: {curveScore}");
//    }
//}
//catch(ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}

#endregion