# Desafio 001 - Quadro de login

[Vídeo do desafio (João Ribeiro)](https://www.youtube.com/watch?v=z6Nm13Aw5YU&list=PLXik_5Br-zO9FfZl6Jd-zsRPyMDXc-CDb&index=2)

## Objetivo

- :heavy_check_mark: Quadro de login com usuário, senha e botão para entrar. 
- :heavy_check_mark: Ao teclar enter, passar para campo seguinte ou executar automaticamente o evento para entrar. 
- :heavy_check_mark: Suprimir os Beeps na passagem dos campos.

## Conceitos aprendidos

Caixas de feramentas -> Controles comuns
* TextBox
* Label
* Button

### Propriedades de controles

* `Text`: texto que será exibido 
* `Name`: como o campo será acessado pelo programa (parte lógica)

### Ordem de tabulação (tab order): elementos que receberão foco

1. Caso não esteja aparecendo a opção de ordem de tabulação, siga os seguintes passos:

![Habilitar Botão ordem de tabulação](/img/habilitar_botao_tabulacao.png)

2. Com a opção habilitada, clique nos elementos desejados para alterar a ordem.

![Habilitar Botão ordem de tabulação](/img/ordem_tabulacao.png)

3. Para finalizar o modo de edição da tabulação, basta clicar no botão novamente.

### Centralizar a aplicação na tela

Para garantir que a aplicação comece centralizada na tela do computador, mude a seguinte propriedade.

`StartPosition`: CenterScreen

### Desabilitando o botão de entrar até que ambos os campos estejam preenchidos

1. Duplo clique no formulário, para que seja aberto o Form1.cs

```c#
private void Form1_Load(object sender, EventArgs e)
{
    cmd_entrar.Enabled = false;
}
```

### Eventos

A zona de eventos pode ser encontrada no menu de propriedades do controle, no ícone de raio.
Ao lado do nome do evento, você pode definir o nome de uma função, como no exemplo abaixo:

![Eventos](/img/TextChanged.png)


* `TextChanged`

```c#
// Habilita o botão 'cmd_entrar' quando as duas TextBoxs 'text_usuario' e 'text_senha' estiverem preenchidas (ou seja != "")

private void text_textChanged(object sender, EventArgs e)
{    
    cmd_entrar.Enabled = (text_usuario.Text != "") && (text_senha.Text != "");
}
```
* `KeyDown`: Evento
* `e.KeyCode == Keys.Enter`: verifica se a tecla pressionada é o Enter
* `nome_controle.Focus()`: define o elemento que terá foco
* `e.Handled = true` e `e.SuppressKeyPress = true`: suprimir o beep ao pressionar o Enter


```c#
private void text_usuario_KeyDown(object sender, KeyEventArgs e)
{
    if(e.KeyCode == Keys.Enter)
    {
        text_senha.Focus();
        e.Handled = true;
        e.SuppressKeyPress = true;
    }
}

private void text_senha_KeyDown(object sender, KeyEventArgs e)
{
    if (e.KeyCode == Keys.Enter)
    {
        cmd_entrar_Click(this, EventArgs.Empty);
        e.Handled = true;
        e.SuppressKeyPress = true;
    }
}
```

* `MessageBox.Show("Texto")`: abrir uma nova janela com um alerta

```c#
private void text_senha_KeyDown(object sender, KeyEventArgs e)
{
    if (e.KeyCode == Keys.Enter)
    {
    cmd_entrar_Click(this, EventArgs.Empty);
    e.Handled = true;
    e.SuppressKeyPress = true;
    }
}

private void cmd_entrar_Click(object sender, EventArgs e)
{
    if (!(cmd_entrar.Enabled)) return; //se o botão nao estiver habilitado (ou seja, com texto em ambas as textboxs), o programa retorna, sem executar a próxima linha
    MessageBox.Show("Entrou!");
}
```





