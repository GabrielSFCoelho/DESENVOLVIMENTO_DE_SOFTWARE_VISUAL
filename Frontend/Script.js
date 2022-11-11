function Login() {

	var redirect = {
        'admin':"Inicio.html?usuarioLogado=adm"
	};

    if (!document.login_form.txtUsuario.value) {
        alert("Favor colocar o Usuário !");
        document.login_form.txtUsuario.focus();
        return;
    }

    if (!document.login_form.txtSenha.value) {
        alert("Favor colocar a Senha !");
        document.login_form.txtSenha.focus();
        return;
    }

	if (!redirect[document.login_form.txtUsuario.value]) {
		alert('Usurio não cadastrado');
		return;
        
	}
	window.location.href = redirect[document.login_form.txtUsuario.value];
}
