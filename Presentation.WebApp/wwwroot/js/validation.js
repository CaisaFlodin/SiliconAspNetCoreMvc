const formErrorHandler = (element, validationResult) => {
    let spanElement = document.querySelector(`[data-valmsg-for="${element.name}"]`)

    if (validationResult) {
        element.classList.remove('input-validation-error')
        spanElement.classList.remove('field-validation-error')
        spanElement.classList.add('field-validation-valid')
        spanElement.innerHTML = ''
    }
    else {
        element.classList.add('input-validation-error')
        spanElement.classList.add('field-validation-error')
        spanElement.classList.remove('field-validation-valid')
        spanElement.innerHTML = element.dataset.valRequired
    }
}

const textValidator = (element, minLength = 2) => {
    if (element.value.length >= minLength)
        formErrorHandler(element, true)
    else
        formErrorHandler(element, false)
}

const emailValidator = (element) => {
    const regEx = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|.(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
    formErrorHandler(element, regEx.test(element.value))
}

const passwordValidator = (element) => {
    if (element.dataset.valEqualtoOther !== undefined) {
        let password = document.getElementsByName(element.dataset.valEqualtoOther.replace('*', 'Form'))[0].value

        if (element.value === password)
            formErrorHandler(element, true)
        else
            formErrorHandler(element, false)
    }
    else {
        const regEx = /^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#\$%\^&\*])(?=.{8,})/
        formErrorHandler(element, regEx.test(element.value))
    }
}

const checkBoxValidator = (element) => {
    if (element.checked)
        formErrorHandler(element, true)
    else
        formErrorHandler(element, false)
}

let forms = document.querySelectorAll('form')

forms.forEach(form => {
    let inputs = form.querySelectorAll('input');

    inputs.forEach(input => {
        if (input.dataset.val === 'true') {

            if (input.type === 'checkbox' && input.classList != "rememberMe") {
                input.addEventListener('change', (e) => {
                    checkBoxValidator(e.target)
                })
            } else {

                input.addEventListener('keyup', (e) => {
                    switch (e.target.type) {
                        case 'text':
                            textValidator(e.target)
                            break;
                        case 'email':
                            emailValidator(e.target)
                            break;
                        case 'password':
                            passwordValidator(e.target)
                            break;
                    }
                })
            }
        }
    })
})