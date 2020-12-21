﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="_Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <h2>关于本站</h2>
    <hr />
    <p>
      
      * 本站是由黑暗之魂爱好者所建立的维基站点。维基的内容可涵盖黑暗之魂全系列游戏。<br>
      * 维基目前处于起步阶段，资料仍十分匮乏，欢迎大家一起参与建设。动手前请先参考一下施工须知。<br>
      * 如果在维基编辑上遇到问题，可以查阅灰机wiki的帮助文档或联系管理员。<br>
    </p>

    <h2>施工进度</h2>
    <hr />
    <ul>
        <li>已经将黑魂1的武器戒指的数据全部上传，但具体的小知识还没有编辑，大家查阅的时候可以顺便编辑，目前维基是开放编辑的
黑魂2目前还没有编辑，网上的资料也比较少，需要大家的帮助
黑魂3目前正在编写武器的小知识界面
如果有兴趣长期在黑魂维基编辑，可以加入交流群</li>
    </ul>
        <h2>评论</h2><hr />

     <asp:LinqDataSource ID="ldsUser" EnableDelete="true"   EnableUpdate="true" runat="server" ContextTypeName="DataClassesDataContext" TableName="Comment" >
        
    </asp:LinqDataSource>
    <asp:ScriptManager ID="script_manager" runat="server"></asp:ScriptManager>
 <asp:TextBox runat="server" Cssclass="comment_panel" id="comment_input" style="width:60%;height:100px;margin:10px;text-align:left" placeholder="在此处添加评论"/>
            <br />
            <asp:button runat="server" ID="add_comment_btn" OnClick="add_comment_btn_Click"  style="text-align:end;margin-left:10px;" Text="发布评论"></asp:button>
    <asp:UpdatePanel ID="update_panel"  runat="server" UpdateMode="Conditional">
        <ContentTemplate>
    <asp:Repeater ID="comment_repeater"  runat="server">
        <ItemTemplate>
            <div class="comment_panel">
                <image class="headIcon" src="../Images/icon.jpg"></image>
                <span style="position:center"> <%# Eval("user") %> <a><%# Eval("time") %></a> 
                    <%# Eval("text") %>
                </span>
            </div>
        </ItemTemplate>
    </asp:Repeater>
            <asp:Button ID="refresh"  runat="server"/>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="add_comment_btn" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>

