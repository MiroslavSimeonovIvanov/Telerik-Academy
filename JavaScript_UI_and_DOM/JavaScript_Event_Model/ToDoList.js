/* The statement of the problem:
   Create a TODO list with the following UI controls:
   - Form input for new item
   - Button for adding the new item
   - Button for deleting some item
   - Show and hide button
*/

// This function will be executed when addItemButton is clicked and will add new item.
function addNewItem() {
    var addItemButton = document.getElementById("addItemButton");
    addItemButton.addEventListener("click", function onAddItemButtonClick() {
        console.log("Hello user! You have clicked Add Item button and added new item to your shopping basket.");
    }, false);
}

// deleteSomeItem will delete item when deleteItemButton is clicked.
function deleteSomeItem() {
    var deleteItemButton = document.getElementById("deleteItemButton");
    deleteItemButton.addEventListener("click", function onDeleteItemButtonClick() {
        console.log("User you have clicked Delete Item button and deleted some item.");
    }, false);
}

// The function showHideButton will hide the button when the cursor is moved over it.
function hideButton() {
    var showHideButton = document.getElementById("showHideButton");
    showHideButton.addEventListener("mouseover", function onHideButton() {
        event.target.style.visibility = "hidden";
    }, false);
}
