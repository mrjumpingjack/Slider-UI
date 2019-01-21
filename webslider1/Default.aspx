<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="webslider1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <table>
            <tr>
                <table>
                    <tr>
                        <td>
                            <asp:DropDownList Height="50" Width="200" ID="ComPortList" runat="server"></asp:DropDownList>
                        </td>
                        <td>
                            <asp:Button Height="50" runat="server" ID="BtnGetBounds" Text="Initialisieren" OnClick="btnGetBounds_Click" />
                        </td>
                    </tr>
                </table>
            </tr>

            <tr>
                <table>
                    <tr>
                        <td>
                            <asp:TextBox TextMode="Number" Width="100" runat="server" min="235" max="1000" step="1" ID="NUD_Speed" />
                            <asp:Button Height="50" runat="server" ID="BtnSetSpeed" Text="Set Speed" OnClick="btnSetSpeed_Click" />
                        </td>

                        <td>
                            <asp:TextBox TextMode="Number" Width="100" runat="server" min="0" max="10000" step="1" ID="NUD_Break" />
                            <asp:Button Height="50" runat="server" ID="BtnSetBreak" Text="Set Break" OnClick="btnSetBreak_Click" />
                        </td>
                    </tr>
                </table>
            </tr>

            <tr>
                <table>
                    <tr>
                        <td>
                            <asp:Button Height="50" runat="server" ID="btnGoHome" Text="Go Home" OnClick="btnGoHome_Click" />
                        </td>

                        <td>
                            <asp:Button Height="50" runat="server" ID="btnGoMin" Text="Go to min" OnClick="btnGoMin_Click" />
                        </td>

                        <td>
                            <asp:Button Height="50" runat="server" ID="btnGoMax" Text="Go to max" OnClick="btnGoMax_Click" />
                        </td>
                    </tr>
                </table>
            </tr>

            <tr>
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Delay:" />
                            <asp:TextBox TextMode="Number" Width="100" runat="server" min="0" max="1000" step="1" ID="pendel_delay" />

                            <asp:Label runat="server" Text="Laps:" />
                            <asp:TextBox TextMode="Number" Width="100" runat="server" min="0" max="1000" step="1" ID="pendel_laps" />

                            <asp:Button Height="50" runat="server" ID="btnpendeln" Text="Pendel" OnClick="btnPendln_Click" />
                        </td>
                    </tr>
                </table>
            </tr>

            <tr>
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Start:" />
                            <asp:TextBox TextMode="Number" Width="100" runat="server" min="0" max="1000" step="1" ID="TextBox1" />

                            <asp:Label runat="server" Text="Stop:" />
                            <asp:TextBox TextMode="Number" Width="100" runat="server" min="0" max="1000" step="1" ID="TextBox2" />

                             <asp:Label runat="server" Text="Manuel:" />
                            <asp:CheckBox ID="timelapseManuel" runat="server" />

                            <asp:Button Height="50" runat="server" ID="btnTimelapseNext" Text="Next" OnClick="btnTimeLapseNext_Click" />
                            <asp:Button Height="50" runat="server" ID="btnTimelapseStart" Text="Start Timelapse" OnClick="btnTimelpse_Click" />
                        </td>
                    </tr>
                    <tr>
                        <table>
                        <td>
                           <asp:Button Height="50" runat="server" ID="setTimeStartMax" Text="Set to max" OnClick="btnPendln_Click" />
                        </td>
                         <td>
                           <asp:Button Height="50" runat="server" ID="setTimeStartMin" Text="Set to min" OnClick="btnPendln_Click" />
                        </td>
                        </table>
                    </tr>
                    <tr>
                        <table>
                        <td>
                           <asp:Button Height="50" runat="server" ID="setTimeStopMax" Text="Set to max" OnClick="btnPendln_Click" />
                        </td>
                         <td>
                           <asp:Button Height="50" runat="server" ID="setTimeStopMin" Text="Set to min" OnClick="btnPendln_Click" />
                        </td>
                    </tr>
                    </table>
                </table>
            </tr>
        </table>
    </div>



    <style>
        .Button {
            margin: 5px;
        }


        table {
            border-collapse: separate;
            border-spacing: 1em 2em;
        }

    </style>

</asp:Content>