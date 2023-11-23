const nameInput = document.getElementById('nameInput');
const phoneInput = document.getElementById('phoneInput');
const emailInput = document.getElementById('emailInput');

nameInput.addEventListener('input', () => {
  nameInput.setCustomValidity('');
  nameInput.checkValidity();
});

nameInput.addEventListener('invalid', () => {
  if(nameInput.value === '') {
    nameInput.setCustomValidity('Введите свое имя!');
  } else {
    nameInput.setCustomValidity('Имя может содержать только латиницу. Повторите ещё раз!');
  }
});

phoneInput.addEventListener('input', () => {
    phoneInput.setCustomValidity('');
    phoneInput.checkValidity();
});

phoneInput.addEventListener('invalid', () => {
    if(phoneInput.value === '') {
        phoneInput.setCustomValidity('Введите свой номер телефона!');
    } else {
        phoneInput.setCustomValidity('Номер должен иметь формат +70000000000. Повторите ещё раз!');
    }
});

emailInput.addEventListener('input', () => {
    emailInput.setCustomValidity('');
    emailInput.checkValidity();
});

emailInput.addEventListener('invalid', () => {
    if(emailInput.value === '') {
        emailInput.setCustomValidity('Введите свой E-mail!');
    } else {
        emailInput.setCustomValidity('Номер должен иметь формат login@site.com. Повторите ещё раз!');
    }
});
