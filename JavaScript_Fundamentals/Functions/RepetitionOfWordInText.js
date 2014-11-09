/* The statement of the problem:
   Write a function that finds all the occurrences of
   word in text.
    - The search can case sensitive or case insensitive
    - Use function overloading
*/

// Here we create two variables - one for the word and one for the text.
var word = "Hulk";
var text = "Labeled Earth's Mightiest Heroes, the Avengers originally consisted of Iron Man, Ant-Man, the Wasp, Thor, and the Hulk. Hulk The team, famous for its battle cry of 'Avengers Assemble!', has featured humans, mutants, robots, aliens, supernatural beings, Hulk and even former villains.";

// Create the function that searches for the word in text.
function searchForWordInText(word) {
    var counter = 0;
    for (var index = 0; index < text.length; index++) {
        if (text === "Hulk") {
            counter++;
        }
    }
    console.log("The word " + word + " appears in the given text " + counter + " times.");
}

// Function overloading.
searchForWordInText(word, text);
searchForWordInText(word);
