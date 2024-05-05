const showErrorStyles = (container, inputBox) => {
    container.classList.add("error");
    inputBox.classList.add("error");
    container.classList.remove("allow");
    inputBox.classList.remove("allow");
}
const removeErrorStyles = (container, inputBox) => {
    container.classList.remove("error");
    inputBox.classList.remove("error");
    container.classList.add("allow");
    inputBox.classList.add("allow");
}

const fullnameValidate = () => {
    const fullnameContainer = document.querySelector(".sign-up-fullname");
    const fullnameInputBox = document.querySelector(".input-fullname");
    const fullnameMessage = document.querySelector(".fullname-message");
    const fullname = fullnameInputBox.value;

    const containsNumber = () => {
        for (let i = 0; i < fullname.length; ++i) {
            if (!isNaN(parseInt(fullname[i]))) {
                return true;
                break;
            }
        }
        return false;
    }

    if (fullname === "") {
        showErrorStyles(fullnameContainer, fullnameInputBox);
        fullnameMessage.innerHTML = "Hãy điền Họ và tên";
    }
    else if (containsNumber()) {
        showErrorStyles(fullnameContainer, fullnameInputBox);
        fullnameMessage.innerHTML = "Họ và tên không được chứa số";
    }
    else {
        removeErrorStyles(fullnameContainer, fullnameInputBox);
        fullnameMessage.innerHTML = "";
    }
};

const usernameValidate = () => {
    const usernameContainer = document.querySelector(".sign-up-username");
    const usernameInputBox = document.querySelector(".input-username");
    const usernameMessage = document.querySelector(".username-message");
    let username = usernameInputBox.value;

/*Remove white space*/
