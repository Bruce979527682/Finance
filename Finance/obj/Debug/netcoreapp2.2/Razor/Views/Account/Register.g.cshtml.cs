#pragma checksum "C:\Users\Bruce\Desktop\Finance\Finance\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc661b5ffb210f81614139831c91748f0ad5a413"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Bruce\Desktop\Finance\Finance\Views\_ViewImports.cshtml"
using Finance;

#line default
#line hidden
#line 2 "C:\Users\Bruce\Desktop\Finance\Finance\Views\_ViewImports.cshtml"
using Finance.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc661b5ffb210f81614139831c91748f0ad5a413", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78d485da229cf3b9644d6f0c651451eded00a1c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Bruce\Desktop\Finance\Finance\Views\Account\Register.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutLogin.cshtml";

#line default
#line hidden
            BeginContext(95, 1505, true);
            WriteLiteral(@"<style>
    .div-box {
        width: 400px;
        height: 350px;
        box-shadow: 0 2px 12px 0 rgba(0, 0, 0, 0.1);
        position: fixed;
        top: calc(50% - 200px);
        left: calc(50% - 175px);
    }

    .div-head {
        text-align: center;
        font-size: 25px;
        margin-top: 15px;
        height: 30px !important;
    }
    .btn-center {
        margin: 0 auto;
        width: 72px;
    }

    .el-row {
        margin-bottom: 20px;
    }
</style>
<div id=""div-vue"">
    <div class=""div-box"">
        <el-container>
            <el-header class=""div-head"">账号注册</el-header>
            <el-main>
                <el-row :gutter=""10"">
                    <el-col :span=""24"">
                        <el-input v-model=""account.username"" placeholder=""请输入账号""></el-input>
                    </el-col>
                </el-row>
                <el-row :gutter=""10"">
                    <el-col :span=""24"">
                        <el-input v-model=""account.pass");
            WriteLiteral(@"word"" placeholder=""请输入密码"" show-password></el-input>
                    </el-col>
                </el-row>
                <el-row :gutter=""10"">
                    <el-col :span=""24"">
                        <el-input v-model=""account.repassword"" placeholder=""请再次输入密码"" show-password></el-input>
                    </el-col>
                </el-row>
                <el-row :gutter=""10"">
                    <div class=""btn-center"">
                        <el-button ");
            EndContext();
            BeginContext(1601, 1670, true);
            WriteLiteral(@"@click=""postData()"">注册</el-button>
                    </div>
                </el-row>
            </el-main>
        </el-container>
    </div>
</div>
<script>
    var vm = new Vue({
        el: '#div-vue',
        data: {
            isCreated: false,
            queryPara: {
                pageIndex: 1,
                pageSize: 20,
            },
            account: {
                username: '',
                password: '',
                repassword: ''
            }
        },
        methods: {
            loadData() {

            },
            postData() {
                if (this.account.password != this.account.repassword) {
                    vm.$message('两次输入密码不匹配');
                    return;
                }
                $.ajax({
                    url: '/account/addaccount',
                    dataType: 'json',
                    type: ""POST"",
                    data: this.account,
                    success: function (data) {
            ");
            WriteLiteral(@"            if (data.code === 1) {
                            location.href = data.src;
                        }
                        else {
                            vm.$message(data.msg);
                        }
                    },
                    error: function (xhr, status, error) {
                    }
                });
            }
        },
        computed: {

        },
        created: function () {
            this.isCreated = true;
            this.loadData();
        },
        beforeMount: function () {

        },
        mounted: function () {

        }
    });
</script>

");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
