<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerLecturas.aspx.cs" Inherits="Eva3Web.VerLecturas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">

    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Lectura</h3>
                </div>
                <div class="form-group">
                        <label for="medidorDd1">Filtrar por Tipo</label>
                        <asp:DropDownList AutoPostBack="true" OnSelectedIndexChanged="medidorDd1_SelectedIndexChanged" runat="server" ID="medidorDd1" CssClass="form-select">
                            <asp:ListItem Value="1" OnSelectedIndexChanged="medidorDd1_SelectedIndexChanged"></asp:ListItem>
                            <%--<asp:ListItem Value="2" Text="Digital"></asp:ListItem>
                            <asp:ListItem Value="3" Text="6000"></asp:ListItem>--%>
                        </asp:DropDownList>

                    </div>
                <%--<div class="form-group">
                        <label for="medidorDd1">Medidores</label>
                        <asp:DropDownList runat="server" ID="medidorDd1" CssClass="form-select">
                            
                        </asp:DropDownList>
                    </div>--%>
                <div class="card-body">
                    <%--<div class="form-group">
                        <label for="nivelDb1">Filtrar por Nivel</label>
                        <asp:DropDownList AutoPostBack="true" OnSelectedIndexChanged="nivelDb1_SelectedIndexChanged" runat="server" ID="nivelDb1">
                            <asp:ListItem Value="1" Text="Silver"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Gold"></asp:ListItem>
                            <asp:ListItem Value="3" Text="Platinum"></asp:ListItem>
                        </asp:DropDownList>

                    </div>--%>
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
