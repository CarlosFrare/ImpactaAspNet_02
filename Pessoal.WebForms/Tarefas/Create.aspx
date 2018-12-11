<%@ Page Title="Inserir" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Pessoal.WebForms.Tarefas.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1> Nova Tarefa</h1>
    <hr />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    <table>
        <tr>
            <td>Nome</td>
            <td>
                <asp:TextBox ID="nomeTextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Nome é obrigatório" CssClass="text-danger" ControlToValidate="nomeTextBox1">!</asp:RequiredFieldValidator>

            </td>
        </tr>
        <tr>
            <td>Prioridade</td>
            <td>
                <asp:DropDownList ID="prioridadeDropDownList1" runat="server" DataSourceID="prioridadeObjectDataSource" AppendDataBoundItems="true">
                <asp:ListItem Text="Selecione" value="0"></asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="prioridadeRequiredFieldValidator2" runat="server" ErrorMessage="Selecione a prioridade!" ControlToValidate="prioridadeDropDownList1" CssClass="text-danger" InitialValue="0">(!)</asp:RequiredFieldValidator>
                <asp:ObjectDataSource ID="prioridadeObjectDataSource" runat="server" SelectMethod="ObterPrioridade" TypeName="Pessoal.WebForms.Tarefas.Create"></asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td> Concluida</td>
            <td>
                <asp:CheckBox Text="" runat="server" ID="concluidaCheckBox"/>
            </td>
        </tr>
        <tr>
            <td >Observacoes</td>
            <td>
                <asp:TextBox runat="server" ID="observacoesTextBox" TextMode="MultiLine" Rows="5"/>
            </td>
        </tr>
    </table>
    <asp:Button Text="Gravar" runat="server" ID="gravarButton" OnClick="gravarButton_Click"/>
</asp:Content>
