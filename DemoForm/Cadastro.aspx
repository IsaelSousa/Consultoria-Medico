<%@ Page Title="Cadastro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="DemoForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Cadastro</h1>
    <hr />
    <div class="container ">
        <form action="submit" method="post"  id="contact_form">
            <fieldset class="d-grid gap-3 mx-auto">

                <!-- Text input-->

                <div class="form-group">
                  <label class="col-md-3 control-label">Nome</label>  
                  <div class="col-md-3 inputGroupContainer">
                     <div class="input-group">
                         <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                         <input  name="Nome" placeholder="Nome" class="form-control"  type="text">
                     </div>
                  </div>
                </div>

                <!-- Text input-->

                <div class="form-group">
                    <label class="col-md-3 control-label" >Sobrenome</label> 
                    <div class="col-md-3 inputGroupContainer">
                        <div class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                             <input name="Sobrenome" placeholder="Sobrenome" class="form-control"  type="text">
                        </div>
                    </div>
                </div>

                <!-- Text input-->
                <div class="form-group">
                    <label class="col-md-3 control-label">E-Mail</label>  
                    <div class="col-md-3 inputGroupContainer">
                        <div class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-envelope"></i></span>
                            <input name="email" placeholder="Endereço de E-Mail" class="form-control"  type="text">
                        </div>
                   </div>
                </div>


                <!-- Text input-->
       
                <div class="form-group">
                  <label class="col-md-3 control-label">Telefone</label>  
                    <div class="col-md-3 inputGroupContainer">
                    <div class="input-group">
                        <span class="input-group-addon"><i class="glyphicon glyphicon-earphone"></i></span>
                        <input name="telefone" placeholder="(845)555-1212" class="form-control" type="text">
                    </div>
                  </div>
                </div>

                <!-- Text input-->
      
                <div class="form-group">
                    <label class="col-md-3 control-label">Endereço</label>  
                    <div class="col-md-3 inputGroupContainer">
                        <div class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-home"></i></span>
                            <input name="Endereço" placeholder="Endereço" class="form-control" type="text">
                        </div>
                    </div>
                </div>

                <!-- Text input-->
 
                <div class="form-group">
                    <label class="col-md-3 control-label">Cidade</label>  
                    <div class="col-md-3 inputGroupContainer">
                        <div class="input-group">
                             <span class="input-group-addon"><i class="glyphicon glyphicon-home"></i></span>
                             <input name="Cidade" placeholder="Cidade" class="form-control"  type="text">
                        </div>
                  </div>
                </div>

                <!-- Select Basic -->
   
                <div class="form-group"> 
                    <label class="col-md-3 control-label">Estado</label>
                    <div class="col-md-3 selectContainer">
                        <div class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-list"></i></span>
                        <select name="Estado" class="form-control selectpicker" >
                            <option value="Default" >Selecione um Estado</option>
                            <option value="Acre">Acre</option>
                            <option value="Alagoas">Alagoas</option>
                            <option value="Amapá">Amapá</option>
                            <option value="Amazonas">Amazonas</option>
                            <option value="Bahia">Bahia</option>
                            <option value="Ceará">Ceará</option>
                            <option value="Distrito Federal">Distrito</option>
                            <option value="Espirito Santo">Espirito</option>
                            <option value="Goiás">Goiás</option>
                            <option value="Maranhão">Maranhão</option>
                            <option value="Mato Grosso">Mato Grosso</option>
                            <option value="Mato Grosso do Sul">Mato Grosso do Sul</option>
                            <option value="Minas Gerais">Minas Gerais</option>
                            <option value="Pará">Pará</option>
                            <option value="Paraíba">Paraíba</option>
                            <option value="Paraná">Paraná</option>
                            <option value="Pernambuco">Pernambuco</option>
                            <option value="Piauí">Piauí</option>
                            <option value="Rio de Janeiro">Rio de Janeiro</option>
                            <option value="Rio Grande do Norte">Rio Grande do Norte</option>
                            <option value="Rio Grande do Sul">Rio Grande do Sul</option>
                            <option value="Rondônia">Rondônia</option>
                            <option value="Roraima">Roraima</option>
                            <option value="Santa Catarina">Santa Catarina</option>
                            <option value="São Paulo">São Paulo</option>
                            <option value="Sergipe">Sergipe</option>
                            <option value="Tocantins">Tocantins</option>
                        </select>
                      </div>
                    </div>
                </div>

                <!-- Text input-->

                <div class="form-group">
                  <label class="col-md-3 control-label">CEP</label>  
                    <div class="col-md-3 inputGroupContainer">
                    <div class="input-group">
                        <span class="input-group-addon"><i class="glyphicon glyphicon-home"></i></span>
                  <input name="cep" placeholder="00000-000" class="form-control"  type="text">
                    </div>
                </div>
                </div>

            </fieldset>
            <div class="form-group mt-6">
                <label class="col-md-3 control-label"></label>
                <div class="col-md-3">
                    <button type="submit" class="btn btn-primary" >Send <span class="glyphicon glyphicon-send"></span></button>
                </div>
            </div>
        </form>
    </div>
     <!-- Button -->
    

</asp:Content>
