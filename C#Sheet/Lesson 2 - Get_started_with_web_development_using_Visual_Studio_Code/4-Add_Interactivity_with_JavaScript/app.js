//* Set Strict mode 
/*
    * JavaScript was designed top be easy to learn and allow the developer to make certain mistakes. For examples, JavaScript doesn't throw an error when you use
    * a misspelled variable, and instead creates a new global one. When you start learning JavaScript, having fewer erros is conveniet, However, it can lead to writing
    * code that is harder for browsers to optimize and harder for you to debug.
    *
    * Switch to strict mode to get more useful erros whe you make mistakes
*/

//* Add an event handler
/*
    * To make the button do something when you select it, you need an event handler in your JavaScript file. An event handler is a way to run a JavaScript
    * function when an event happens on the pages. For the button, let's add an event handler for the 'click' event; the event handler functiopn runs when the click
    *  event occuurs
*/

//* document.querySelector
/*
    * The 'documento.querySelector' function uses CSS selectors, just like the ones you used in your CSS file. Switcher is now
    * a reference to the button in the page
*/

/*
    * In the code, we used the 'toggle' methid to modify the '<body>' element's class attribute. This method automatically adds or removes the 'light-theme' and 'dark-theme' classes.
    * This code applies the dark styles intead of light styles if you click, and then light styles instead of dark if u click again.
    *
    * However, the label for the button also needs to be updated to show the correct theme, so you need to add an 'if' statement to determine the current theme, and update
    * the button label.
    *
    * It's a JavaScript convention to use camel case for variables names with more than one word; for example, the variable 'className'
*/

//* Console Message
/*
    * As a web developer, you can create hidden messages that aren't visible on your webpage, but you can read in the Developer Tools in the Console tab. Using console messages
    * is helpful for seeing the result of your code.
*/

'use strict';

const switcher = document.querySelector('.btn');

switcher.addEventListener(
    'click',
    function()
    {
        document.body.classList.toggle('light-theme');
        document.body.classList.toggle('dark-theme');

        const className = document.body.className;
        if(className == 'light-theme')
        {
            this.textContext = 'Dark';
        }
        else
        {
            this.textContext = 'Light';
        }
        console.log('current class name: ' + className);
    }
);