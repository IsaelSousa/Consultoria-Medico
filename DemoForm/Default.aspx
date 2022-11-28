<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DemoForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="jumbotron">
        <h1>Consulta Médica</h1>
        <p class="lead">Cadastre-se e receba informações do nosso plantão de vendas.</p>
        <p><a href="/Cadastro" class="btn btn-primary btn-lg">Cadastre-se agora &raquo;</a></p>
    </div>

     <div class="container">
        <div class="row">
            <div class="col-lg-6 mb-4">
                <div class="card">
                    <img class="card-img-top" src="consulta.jpg" alt="" width="200" height="200">
  
                    <div class="card-body">
                        <strong class="card-title">Consulta</strong>
                        <p class="card-text">
                           Consulte agora os seus dados no Teleatendimento medicinal.   
                        </p>
                        <a href="/Consulta" class="btn btn-primary">Consultar</a>
                    </div>
                </div>
            </div>
            <div class="col-lg-6 mb-4">
                <div class="card">
                    <img class="card-img-top" src="medicina.png" alt="" width="200" height="200">
  
                    <div class="card-body">
                        <strong class="card-title">Medicina</strong>
                        <p class="card-text">
                           Mais notícias sobre medicina e sua relevância.
                        </p>
                        <a href="https://www.bbc.com/portuguese/topics/c8y94y3jj2kt" class="btn btn-primary">Saiba Mais</a>
                    </div>
                </div>
            </div>
              <div class="col-lg-6 mb-4">
                <div class="card">
                    <img class="card-img-top" src="faleConosco.jpg" alt="" width="200" height="200">
  
                    <div class="card-body">
                        <strong class="card-title">Fale Conosco</strong>
                        <p class="card-text">
                           Se houver alguma dúvida, procure nos para sanar.
                        </p>
                        <a href="/Contact" class="btn btn-primary">Contate-nos</a>
                    </div>
                </div>
            </div>
              <div class="col-lg-6 mb-4">
                <div class="card">
                    <img class="card-img-top" src="especialidades.png" alt="" width="200" height="200">
  
                    <div class="card-body">
                        <strong class="card-title">Busque Médico</strong>
                        <p class="card-text">
                            Caso haja alguma dúvida, busque informações sobre seu médico através do CRM.
                        </p>
                        <a href="https://portal.cfm.org.br/busca-medicos/" class="btn btn-primary">Buscar</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
       
    
</asp:Content>
