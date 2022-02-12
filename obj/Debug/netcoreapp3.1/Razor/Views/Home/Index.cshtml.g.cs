#pragma checksum "C:\Users\felip\OneDrive\Documentos\BMW-MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ea51768f9ffa62ddf1cd55ae1adff2770343e4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\felip\OneDrive\Documentos\BMW-MVC\Views\_ViewImports.cshtml"
using BMW_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\felip\OneDrive\Documentos\BMW-MVC\Views\_ViewImports.cshtml"
using BMW_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ea51768f9ffa62ddf1cd55ae1adff2770343e4b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"049f45f9aa72febeac1f9e5dc236b77e80baa2c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("subscribe__form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\felip\OneDrive\Documentos\BMW-MVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n    <html lang=\"pt-br\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ea51768f9ffa62ddf1cd55ae1adff2770343e4b4389", async() => {
                WriteLiteral(@"
        <meta charset=""UTF-8"">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">

        <!--=============== REMIXICONS ===============-->
        <link href=""https://cdn.jsdelivr.net/npm/remixicon@2.5.0/fonts/remixicon.css"" rel=""stylesheet"">
        
        <!--=============== SWIPER CSS ===============-->
        <link rel=""stylesheet"" href=""/css/swiper-bundle.min.css"">

        <!--=============== CSS ===============-->
        <link rel=""stylesheet"" href=""/css/styles.css"">

    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ea51768f9ffa62ddf1cd55ae1adff2770343e4b5906", async() => {
                WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome to BMW Brasil</h1>
    <p>Bem-vindo ao seu prazer em dirigir.</p>
</div>

<section class=""home"" id=""home"">
                <img src=""/Imagens/background.jpg"" alt=""Background"" class=""home__img"">

  <div class=""home__container container grid"">
                    <div class=""home__data"">
                        <span class=""home__data-subtitle"">THE M4 Competition</span>
                        <h1 class=""home__data-title"">Puro <br> <b>Prazer</b> De <br> Dirigir</h1>
                        <a href=""https://www.bmw.com.br/pt/all-models/m-series/bmw-m440i-coupe/2020/bmw-serie-4-coupe-versao-m-destaques.html"" class=""button"">Descubra</a>

                    </div>

                    <div class=""home__social"">
                        <a href=""https://www.facebook.com/BMWBrasil/"" target=""_blank"" class=""home__social-link"">
                            <i class=""ri-facebook-box-fill""></i>
                        </a>
                   ");
                WriteLiteral(@"     <a href=""https://www.instagram.com/bmwdobrasil/"" target=""_blank"" class=""home__social-link"">
                            <i class=""ri-instagram-fill""></i>
                        </a>
                        <a href=""https://twitter.com/bmwbrasil"" target=""_blank"" class=""home__social-link"">
                            <i class=""ri-twitter-fill""></i>
                        </a>
                    </div>

                    
                </div>
            </section>

            <!--==================== ABOUT ====================-->
            <section class=""about section"" id=""about"">
                <div class=""about__container container grid"">
                    <div class=""about__data"">
                        <h2 class=""section__title about__title"">My Bmw App <br></h2>
                        <p class=""about__description"">Your World. My BMW. <br> Descubra as vantagens do novo aplicativo My BMW.
                        </p>
                        <a href=""#"" class=""button"">Sa");
                WriteLiteral("iba mais</a>\r\n                    </div>\r\n\r\n                    <div class=\"about__img\">\r\n                        <div class=\"about__img-overlay\">\r\n                            <img src=\"/imagens/MyBMW_Module_Mobile.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 2915, "\"", 2921, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"about__img-one\">\r\n                        </div>\r\n\r\n                        <div class=\"about__img-overlay\">\r\n                            <img src=\"/imagens/vehicle-status-mobile.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 3113, "\"", 3119, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""about__img-two"">
                        </div>
                    </div>
                </div>
            </section>
            
            <!--==================== DISCOVER ====================-->
            <section class=""discover section"" id=""discover"">
                <h2 class=""section__title"">BMW do Brasil recomenda <br> BESTSELLER</h2>
                
                <div class=""discover__container container swiper-container"">
                    <div class=""swiper-wrapper"">
                        <!--==================== DISCOVER 1 ====================-->
                        <div class=""discover__card swiper-slide"">
                            <img src=""Imagens/i4BMW.png""");
                BeginWriteAttribute("alt", " alt=\"", 3844, "\"", 3850, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""discover__img"">
                            <div class=""discover__data"">
                                <h2 class=""discover__title""></h2>
                                <span class=""discover__description""></span>
                            </div>
                            <div class=""Texto_BMW""><br><h2>BMW I4</h2><br>O PRIMEIRO GRAN COUPÉ TOTALMENTE ELÉTRICO</div>
                        </div>

                        <!--==================== DISCOVER 2 ====================-->
                        <div class=""discover__card swiper-slide"">
                            <img src=""Imagens/cosySec1.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 4482, "\"", 4488, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""discover__img"">
                            <div class=""discover__data"">
                                <h2 class=""discover__title""></h2>
                                <span class=""discover__description""></span>
                            </div>
                            <div class=""Texto_BMW""><br><h2>BMW M3 Competition</h2><br>O ÍCONE DA BMW M</div>
                        </div>

                        <!--==================== DISCOVER 3 ====================-->
                        <div class=""discover__card swiper-slide"">
                            <img src=""Imagens/cosySec2.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 5107, "\"", 5113, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""discover__img"">
                            <div class=""discover__data"">
                                <h2 class=""discover__title""></h2>
                                <span class=""discover__description""></span>
                            </div>
                            <div class=""Texto_BMW""><br><h2>BMW 530e M Sport</h2><br>O ÁPICE DA TECNOLOGIA, DESEMPENHO E CONECTIVIDADE</div>
                        </div>

                        <!--==================== DISCOVER 4 ====================-->
                        <div class=""discover__card swiper-slide"">
                            <img src=""Imagens/cosySec.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 5762, "\"", 5768, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""discover__img"">
                            <div class=""discover__data"">
                                <h2 class=""discover__title""></h2>
                                <span class=""discover__description""></span>
                            </div>
                            <div class=""Texto_BMW""><br><h2>BMW X3</h2><br>ELETRIFIQUE SUAS AVENTURAS</div>
                        </div>
                    </div>
                </div>
            </section>

            <!--==================== EXPERIENCE ====================-->
            <section class=""experience section"">
                <h2 class=""section__title"">BMW SERVIÇOS <br></h2>

                <div class=""experience__container container grid"">
                    <div class=""experience__content grid"">
                        <div class=""experience__data"">
                            <h2 class=""experience__number"">BMW SERVIÇOS</h2>
                            <span class=""experience__description"">Equipe altamente qualif");
                WriteLiteral(@"icada, peças e produtos originais BMW e atendimento Premium. O cuidado é nosso. O Puro Prazer de Dirigir é seu. <br></span>
                        </div>

                        <div class=""experience__data"">
                            <h2 class=""experience__number"">SIMULADOR SING & GO</h2>
                            <span class=""experience__description"">A conquista do seu BMW 0km está mais próxima do que você imagina. <br></span>
                        </div>

                        <div class=""experience__data"">
                            <h2 class=""experience__number"">VENDAS ESPECIAIS</h2>
                            <span class=""experience__description"">Condiçoes exclusivas para você e sua empresa<br></span>
                        </div>
                    </div>

                    <div class=""experience__img grid"">
                        <div class=""experience__overlay"">
                            <img src=""Imagens/bmw-servicos3.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 7774, "\"", 7780, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"experience__img-one\">\r\n                        </div>\r\n                        \r\n                        <div class=\"experience__overlay\">\r\n                            <img src=\"Imagens/experience2.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 7991, "\"", 7997, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""experience__img-two"">
                        </div>
                    </div>
                </div>
            </section>

            <!--==================== VIDEO ====================-->
            <section class=""video section"">
                <h2 class=""section__title""> O FUTURO É AGORA</h2>

                <div class=""video__container container"">
                    <p class=""video__description"">iX e i4 <br>O futuro não é ontem, nem hoje, nem amanhã o futuro é BMW NOW.
                    </p>

                    <div class=""video__content"">
                        <video id=""video-file"">
                            <source src=""/Videos/Next Brasil - Episódio 5 - iX e i4_ O Futuro Chegou.mp4"" type=""video/mp4"">
                        </video>

                        <button class=""button button--flex video__button"" id=""video-button"">
                            <i class=""ri-play-line video__button-icon"" id=""video-icon""></i>
                        </button>
       ");
                WriteLiteral(@"             </div>
                </div>
            </section>

            <!--==================== PLACES ====================-->
            <section class=""place section"" id=""place"">
                <h2 class=""section__title"">Conquiste seu BMW e curta o Puro Prazer de Dirigir!</h2>

                <div class=""place__container container grid"">
                    <!--==================== PLACES CARD 1 ====================-->
                    <div class=""place__card"">
                        <img");
                BeginWriteAttribute("src", " src=\"", 9543, "\"", 9549, 0);
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 9550, "\"", 9556, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"place__img\">\r\n                        \r\n                        <div class=\"place__content\">\r\n                            <span class=\"place__rating\">\r\n                                <i");
                BeginWriteAttribute("class", " class=\"", 9751, "\"", 9759, 0);
                EndWriteAttribute();
                WriteLiteral(@"></i>
                                <span class=""place__rating-number""></span>
                            </span>

                            <div class=""place__data"">
                                <h3 class=""place__title"">BMW</h3>
                                <span class=""place__subtitle"">7SERIES</span>
                                <span class=""place__price"">R$ 656.950</span>
                            </div>
                        </div>

                        <button");
                BeginWriteAttribute("class", " class=\"", 10261, "\"", 10269, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <i");
                BeginWriteAttribute("class", " class=\"", 10303, "\"", 10311, 0);
                EndWriteAttribute();
                WriteLiteral(@"></i>
                        </button>
                    </div>

                    <!--==================== PLACES CARD 2 ====================-->
                    <div class=""place__card"">
                        <img src=""Imagens/BMW-i-series-i3-range-ts-01.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 10589, "\"", 10595, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"place__img\">\r\n                    \r\n                        <div class=\"place__content\">\r\n                            <span class=\"place__rating\">\r\n                                <i");
                BeginWriteAttribute("class", " class=\"", 10786, "\"", 10794, 0);
                EndWriteAttribute();
                WriteLiteral(@"></i>
                                <span class=""place__rating-number""></span>
                            </span>

                            <div class=""place__data"">
                                <h3 class=""place__title"">BMW</h3>
                                <span class=""place__subtitle"">I3</span>
                                <span class=""place__price"">R$ 304.950</span>
                            </div>
                        </div>

                        <button class=""button button--flex place__button"">
                            <i class=""ri-arrow-right-line""></i>
                            </a>
                        </button>
                    </div>

                    <!--==================== PLACES CARD 3 ====================-->
                    <div class=""place__card"">
                        <img");
                BeginWriteAttribute("src", " src=\"", 11659, "\"", 11665, 0);
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 11666, "\"", 11672, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"place__img\">\r\n                        \r\n                        <div class=\"place__content\">\r\n                            <span class=\"place__rating\">\r\n                                <i");
                BeginWriteAttribute("class", " class=\"", 11867, "\"", 11875, 0);
                EndWriteAttribute();
                WriteLiteral(@"></i>
                                <span class=""place__rating-number""></span>
                            </span>

                            <div class=""place__data"">
                                <h3 class=""place__title"">BMW</h3>
                                <span class=""place__subtitle"">I3</span>
                                <span class=""place__price"">R$ 304.950</span>
                            </div>
                        </div>

                        <button");
                BeginWriteAttribute("class", " class=\"", 12372, "\"", 12380, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <i");
                BeginWriteAttribute("class", " class=\"", 12414, "\"", 12422, 0);
                EndWriteAttribute();
                WriteLiteral("></i>\r\n                        </button>\r\n                    </div>\r\n\r\n                    <!--==================== PLACES CARD 4 ====================-->\r\n                    <div class=\"place__card\">\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 12654, "\"", 12660, 0);
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 12661, "\"", 12667, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"place__img\">\r\n                        \r\n                        <div class=\"place__content\">\r\n                            <span class=\"place__rating\">\r\n                                <i");
                BeginWriteAttribute("class", " class=\"", 12862, "\"", 12870, 0);
                EndWriteAttribute();
                WriteLiteral(@"></i>
                                <span class=""place__rating-number""></span>
                            </span>

                            <div class=""place__data"">
                                <h3 class=""place__title"">BMW</h3>
                                <span class=""place__subtitle"">X5</span>
                                <span class=""place__price"">R$ 557.950</span>
                            </div>
                        </div>

                        <button");
                BeginWriteAttribute("class", " class=\"", 13367, "\"", 13375, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <i");
                BeginWriteAttribute("class", " class=\"", 13409, "\"", 13417, 0);
                EndWriteAttribute();
                WriteLiteral(@"></i>
                        </button>
                    </div>

                    <!--==================== PLACES CARD 5 ====================-->
                    <div class=""place__card"">
                        <img src=""Imagens/BMW-7series.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 13679, "\"", 13685, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"place__img\">\r\n                        \r\n                        <div class=\"place__content\">\r\n                            <span class=\"place__rating\">\r\n                                <i");
                BeginWriteAttribute("class", " class=\"", 13880, "\"", 13888, 0);
                EndWriteAttribute();
                WriteLiteral(@"></i>
                                <span class=""place__rating-number""></span>
                            </span>

                            <div class=""place__data"">
                                <h3 class=""place__title"">BMW</h3>
                                <span class=""place__subtitle"">7SERIES</span>
                                <span class=""place__price"">R$ 656.950</span>
                            </div>
                        </div>

                        <button class=""button button--flex place__button"">
                            <i class=""ri-arrow-right-line""></i>
                        </button>
                    </div>
                </div>
            </section>

            <!--==================== SUBSCRIBE ====================-->
            <img class=""Ibama"" src=""Imagens/IBAMA_LOGO.png"">
            <section class=""subscribe section"">
                <div class=""subscribe__bg"">
                    <div class=""subscribe__container container"">
      ");
                WriteLiteral(@"                  <h2 class=""section__title subscribe__title"">Solicite uma proposta<br></h2>
                        <p class=""subscribe__description"">Solicite sua proposta com um de nossos atendentes mais especializados na área.
                        </p>
    
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ea51768f9ffa62ddf1cd55ae1adff2770343e4b25140", async() => {
                    WriteLiteral(@"
                            <input type=""text"" placeholder=""E-mail"" class=""subscribe__input"">
    
                            <button class=""button"">
                                Enviar
                            </button>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                </div>
            </section>
            
            <!--==================== SPONSORS ====================-->
            <section class=""sponsor section"">
                <div class=""sponsor__container container grid"">
                    <div class=""sponsor__content"">
                        <img src=""#""");
                BeginWriteAttribute("alt", " alt=\"", 15874, "\"", 15880, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"sponsor__img\">\r\n                    </div>\r\n                    <div class=\"sponsor__content\">\r\n                        <img src=\"Imagens/MINI_logo.png\"");
                BeginWriteAttribute("alt", " alt=\"", 16041, "\"", 16047, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"sponsor__img\">\r\n                    </div>\r\n                    <div class=\"sponsor__content\">\r\n                        <img src=\"Imagens/BMW-Logo.png\"");
                BeginWriteAttribute("alt", " alt=\"", 16207, "\"", 16213, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"sponsor__img\">\r\n                    </div>\r\n                    <div class=\"sponsor__content\">\r\n                        <img src=\"Imagens/Rolls-Royce-Logo.png\"");
                BeginWriteAttribute("alt", " alt=\"", 16381, "\"", 16387, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"sponsor__img\">\r\n                    </div>\r\n                    <div class=\"sponsor__content\">\r\n                        <img src=\"#\"");
                BeginWriteAttribute("alt", " alt=\"", 16528, "\"", 16534, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""sponsor__img"">
                    </div>
                </div>
            </section>
        </main>

        <!--==================== FOOTER ====================-->
        <footer class=""footer section"">
            <div class=""footer__container container grid"">
                <div class=""footer__content grid"">
                    <div class=""footer__data"">
                        <h3 class=""footer__title"">Contato</h3>
                        <ul>
                        <li class=""footer__item"">
                            <a");
                BeginWriteAttribute("href", " href=\"", 17095, "\"", 17102, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer__link\">Fale com a BMW</a>\r\n                        <li class=\"footer__item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 17230, "\"", 17237, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""footer__link"">Carreiras</a>
                        </li>
                        </li>
                        </ul>
                        <div>
                            <a href=""https://www.facebook.com/BMWBrasil/"" target=""_blank"" class=""footer__social"">
                                <i class=""ri-facebook-box-fill""></i>
                            </a>
                            <a href=""https://twitter.com/bmwbrasil"" target=""_blank"" class=""footer__social"">
                                <i class=""ri-twitter-fill""></i>
                            </a>
                            <a href=""https://www.instagram.com/bmwdobrasil/"" target=""_blank"" class=""footer__social"">
                                <i class=""ri-instagram-fill""></i>
                            </a>
                            <a href=""https://www.youtube.com/user/BMWTVBrasil"" target=""_blank"" class=""footer__social"">
                                <i class=""ri-youtube-fill""></i>
                            </a>");
                WriteLiteral(@"
                        </div>
                    </div>
    
                    <div class=""footer__data"">
                        <h3 class=""footer__subtitle"">Meu BMW</h3>
                        <ul>
                            <li class=""footer__item"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 18564, "\"", 18571, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer__link\">Solicitar uma proposta</a>\r\n                            </li>\r\n                            <li class=\"footer__item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 18746, "\"", 18753, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer__link\">Modelos e Preços</a>\r\n                            </li>\r\n                            <li class=\"footer__item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 18922, "\"", 18929, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""footer__link""></a>
                            </li>
                        </ul>
                    </div>
    
                    <div class=""footer__data"">
                        <h3 class=""footer__subtitle"">Infomações Legais</h3>
                        <ul>
                            <li class=""footer__item"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 19302, "\"", 19309, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer__link\">Política de Cookies</a>\r\n                            </li>\r\n                            <li class=\"footer__item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 19481, "\"", 19488, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer__link\">Política de Privacidade</a>\r\n                            </li>\r\n                            <li class=\"footer__item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 19664, "\"", 19671, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer__link\">Recall</a>\r\n                            </li>\r\n                            <li class=\"footer__item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 19830, "\"", 19837, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""footer__link"">Manual de Segurança</a>
                            </li>
                        </ul>
                    </div>
    
<br>
                <div class=""footer__rights"">
                    <p class=""footer__copy"">&#169; BMW GROUP Brasil 2021</p>
                    <div class=""footer__terms"">
                        <a href=""https://www.bmw.com.br/pt/footer/footer-section/cookie-policy.html"" class=""footer__terms-link"">Política de Cookies</a>
                        <a href=""https://www.bmw.com.br/pt/footer/footer-section/legal-notice.html"" class=""footer__terms-link"">Política de Privacidade</a>
                    </div>
                </div>
            </div>
        </footer>

         <!--========== SCROLL UP ==========-->
        <a href=""#"" class=""scrollup"" id=""scroll-up"">
            <i class=""ri-arrow-up-line scrollup__icon""></i>
        </a>

        <!--=============== SCROLL REVEAL===============-->
        <script src=""scrollreveal.min.js""></script>
  ");
                WriteLiteral("      \r\n        <!--=============== SWIPER JS ===============-->\r\n        <script src=\"/js/swiper-bundle.min.js\"></script>\r\n\r\n        <!--=============== MAIN JS ===============-->\r\n        <script src=\"/js/main.js\"></script>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
