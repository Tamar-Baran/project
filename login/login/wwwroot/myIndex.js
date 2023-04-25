
async function Register() {
     const userName = document.getElementById("userNameReg").value;
     const password = document.getElementById("passwordReg").value;
     const firstName = document.getElementById("firstName").value;
     const lastName = document.getElementById("lastName").value;
     console.log(userName);
     const response = await fetch('/api/user/register', {
         method: 'POST',
         headers: {
             'Content-Type': 'application/json'
         },
         body: JSON.stringify({ email: userName, password: password, firstName: firstName, lastName: lastName })
     })
     const user = await response.json();
     if (response.ok) {
         alert("registered!");
         localStorage.setItem("user", JSON.stringify(user));
         document.location = "https://localhost:44351/UserDetails.html";
     }
     if (response.status == 404) {
         alert("unable to register");
     }
     if (response.status == 400) {
         alert("you need a better password");
     }
}
async function Login()
{
    
    const userName = document.getElementById("userNameLogIn").value;
    const password = document.getElementById("userPasswordLogIn").value;

    const response = await fetch('/api/user/login', {

        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ "email": userName, "password": password })
    })
   
   
    
    if (response.ok) {
        const user = await response.json();
        alert("logged in");
        localStorage.setItem("user", JSON.stringify(user));
        document.location = "https://localhost:44351/user";
    }
    if (response.status == 404) {
            alert("Incorrect user name or password please try again");
    }

    

}

async function passwordRate() {
    const password = document.getElementById("passwordReg").value;
    
    const response = await fetch('/api/user/password', {

        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ "email": "a@a.a", "password": password })
    })
    const val = await response.json();
    document.getElementById("password_rate").setAttribute("value", val);
}