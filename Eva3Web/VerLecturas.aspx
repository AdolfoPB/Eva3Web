<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerLecturas.aspx.cs" Inherits="Eva3Web.VerLecturas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">

    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Lectura</h3>
                </div>
                <div class="card-body">
                   
                    <asp:GridView CssClass="table table-hover table-bordered mt-5" 
                        EmptyDataText="No hay Lecturas" ShowHeader="true"
                        OnRowCommand="grillaLecturas_RowCommand"
                        AutoGenerateColumns="false" runat="server" ID="grillaLecturas">
                        <Columns>
                            <asp:BoundField DataField="NumeroLec" HeaderText="Numero Medidor" />
                            <asp:BoundField DataField="FechaLec" HeaderText="Fecha" />
                            <asp:BoundField DataField="HoraLec" HeaderText="Hora" />
                            <asp:BoundField DataField="MinutoLec" HeaderText="Minuto" />
                            <asp:BoundField DataField="ConsumoLec" HeaderText="Consumo" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button 
                                        CommandName="eliminar"
                                        CommandArgument='<%# Eval("NumeroLec")%>'
                                        runat="server" 
                                        CssClass="btn bg-danger" Text="Eliminar" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
