<%@ Page Title="Tarefas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Pessoal.WebForms.Tarefas.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Tarefas</h1>
    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="Create">Nova Tarefa</asp:LinkButton>
    <p></p>
    <asp:GridView runat="server" DataSourceID="tarefasObjectDataSource">
        <Columns> <asp:BoundField DataField="Nome"          HeaderText="Nome"/>         </Columns>
        <Columns> <asp:BoundField DataField="Prioridade"    HeaderText="Prioridade"/>   </Columns>
        <Columns> <asp:CheckBoxField DataField="Concluida"     HeaderText="Concluida"/>    </Columns>
        <Columns> <asp:BoundField DataField="Observacoes"   HeaderText="Observacoes"/>  </Columns>

    </asp:GridView>
    <asp:ObjectDataSource runat="server" ID="tarefasObjectDataSource" SelectMethod="Selecionar" TypeName="Pessoal.Repositorios.SqlServer.TarefaRepositorio" />

</asp:Content>
