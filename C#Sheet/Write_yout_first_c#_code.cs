//* C-Sharp Study Sheet
//* Write your first C# code
    //* What to do if you get error message:
    /*
        //* Writing C# code is an exercise in precision. If you type just one character incorrectly, you'll get an error message in the output area
        //* when you run the code
        //*
        //* For exemple, if you were to incorrectly enter a lower-case 'c' in the word console like so:
            //? console.WriteLine("Hello World");
        //* You'd get the following error message:
            //! (1,1): error CS0103: The name 'console' does not exist in the current context
        //* The first part '(1,1)' indicates the line and column where the error ocurred
        //* Case-sensitive languages, meaning that the C# compiler considers 'console' and 'Console' as diferent words cat and dogs. Sometimes, 
        //* he error messages can be a bit misleading. You'll need to understand the true reason why the error exist, and that comes through learning 
        //* more about C#'s syntex
        //*
        //* Similarly, if you used single-quotation marks (') to surround the literal string 'Hello Wordl' like so:
            //? Console.WriteLine('Hello World');
        //* You would get te following error message:
            //! (1,19): error CS1012: Too many characters in character literal
        //* Again, in line 1, character 19 points to the culprit. You can use the message as clue as you investigate the problem
        //* But what does the error messagem means? What exactly is a "Character Literal?" Later, you'll learn more about literals of various data 
        //* types(including characters letrals). For now, be careful when you're entering code.
        //*
        //* Fortunately, errors are never permanent. You merely spot the error, fix it,
        //* and rerun your code.
        //*
        //* The code editor highlights pre-compilation errors to help you easily
        //* identify and correct mistakes as you develop you code. You can think 
        //* of it like a spell-checker that helps you fix grammar or spelling errors
        //* in a document.
    */

    //*Comments:
        //* //-(when i just want comment one line)
        //*  or
        //* /**/ - ('When e want comment a bunch of lines

    //* Commands for logs and console text

    //*The diference between Console.Write and Console.WriteLine:
        //* Console.WriteLine() prints a message to the output console. At the end of
        //* the line, it adds a line feed similar to pressing Enter or Return to create
        //* a new line,

        //* To print to the output console, but without a line feed ate the end, you use the
        //* second technique, Console.Write(). So, the next call to Console.Write() or Console.WriteLine()
        //* prints another message to the same line.

        Console.WriteLine("Hello World");
        Console.Write("Olá ");
        Console.Write("Mundo");

        //* The output must be:
            /*
                //* Hello World
                //* Olá Mundo
            */

        //* This code helps demonstrate the difference between the two methods. A
        //* new line is appende by Console.WriteLine(), and Console.Write() prints the output
        //* on the line
