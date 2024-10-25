Type.registerNamespace("Mscrm.GlobalQuickCreate");Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior=function(){};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.launchGlobalQuickCreate=function(callbacks,entityDisplayName,quickFormEtc,timestampDictionary,createFromId,createFromType,searchText,width,height){window.self.QuickCreateFormLoadStartTime=(new Date).getTime();Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$q(callbacks);Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$n(callbacks,entityDisplayName,quickFormEtc,timestampDictionary,width,height,createFromId,createFromType,searchText)};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.showGlobalQuickCreate=function(){var $v_0=window.self._globalQuickCreate;!IsNull($v_0)&&$v_0&&Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.executeCallbacksAssociatedWithGlobalQuickCreate("open")};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.executeCallbacksAssociatedWithGlobalQuickCreate=function(callbackType,result){var $v_0=window.self._globalQuickCreate;if(!IsNull($v_0)&&$v_0){var $v_1=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$b(),$v_2=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$7($v_1.id);switch(callbackType){case "open":Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$X($v_2,$v_1);break;case "saveinitiated":Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$Z($v_2,$v_1);break;case "savesuccess":Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$a($v_2,result,$v_1);break;case "savefailure":Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$Y($v_2,result,$v_1);break;default:break}}};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.removeGlobalQuickCreateAttachedEvents=function(quickCreateFrameId){var $v_0=window.self;if(quickCreateFrameId!=="NavBarGloablQuickCreate")$v_0=window.parent;var $v_1=$v_0.document.getElementById(CrmEncodeDecode.CrmHtmlAttributeEncode(String.format("globalquickcreate_save_button_{0}",quickCreateFrameId)));!IsNull($v_1)&&$removeHandler($v_1,"click",Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$N);var $v_2=$v_0.document.getElementById(CrmEncodeDecode.CrmHtmlAttributeEncode(String.format("globalquickcreate_cancel_button_{0}",quickCreateFrameId)));!IsNull($v_2)&&$removeHandler($v_2,"click",Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$K);var $v_3=$v_0.document.getElementById(CrmEncodeDecode.CrmHtmlAttributeEncode(String.format("globalquickcreate_cross_anchor_{0}",quickCreateFrameId)));if(!IsNull($v_3)){$removeHandler($v_3,"click",Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$L);$removeHandler($v_3,"keydown",Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$M)}};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$q=function($p0){var $v_0=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$E(),$v_1={},$v_2=$p0.get_callbackDictionary(),$$dict_4=$v_2;for(var $$key_5 in $$dict_4){var $v_3={key:$$key_5,value:$$dict_4[$$key_5]};$v_1[$v_3.key]=$v_3.value}$v_0[String.format(Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$G,$p0.$0_0,Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$H)]=$v_1};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$X=function($p0,$p1){window.parent.QuickCreateIFrameLoadingEndTime=(new Date).getTime();Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$r($p1);Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$S($p1);var $v_0=$p0.onQuickCreateLoadCallback,$v_1=Mscrm.Utilities.executeFunction($v_0,null);!IsNull($v_1)&&$v_1&&Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$6($p1.id)};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$Z=function($p0,$p1){var $v_0=$P_CRM($p1);$v_0.attr("isErrorNotificatonVisible")=="true"&&$v_0.css("margin-top","-22px");var $v_1=$p0.onQuickCreateSaveInitiatedCallback,$v_2=Mscrm.Utilities.executeFunction($v_1,null);!IsNull($v_2)&&$v_2&&Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$6($p1.id)};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$a=function($p0,$p1,$p2){var $v_0=$p0.onQuickCreateSaveSuccessCallback,$v_1=Mscrm.Utilities.executeFunction($v_0,$p1);!IsNull($v_1)&&$v_1&&Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$6($p2.id)};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$Y=function($p0,$p1,$p2){var $v_0=$p0.onQuickCreateSaveFailCallback,$v_1=Mscrm.Utilities.executeFunction($v_0,$p1);!IsNull($v_1)&&$v_1&&Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$6($p2.id);var $v_2=$p1["_error"],$v_3=!IsNull($v_2)?$v_2["DisplayText"]:null;if(!isNullOrEmptyString($v_3)){var $v_4=$P_CRM($p2);$v_4.attr("isErrorNotificatonVisible","true");$v_4.css("margin-top","22px")}};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$W=function($p0,$p1){var $v_0=$p0.onQuickCreateStopLoadCallback,$v_1=Mscrm.Utilities.executeFunction($v_0,null);if(!IsNull($v_1)&&$v_1){Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$6($p1);return true}return false};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$J=function($p0,$p1){var $v_0=$p0.onQuickCreateCancelCallback,$v_1=Mscrm.Utilities.executeFunction($v_0,null);!IsNull($v_1)&&$v_1&&Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$6($p1)};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$r=function($p0){var $v_0=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$7($p0.id),$v_1=new Mscrm.GlobalQuickCreate.RefreshFormCallbacks($p0.id),$v_2=$v_1.get_callbackDictionary(),$$dict_4=$v_2;for(var $$key_5 in $$dict_4){var $v_4={key:$$key_5,value:$$dict_4[$$key_5]};$v_0[$v_4.key]=$v_4.value}var $v_3=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$E();$v_3[String.format(Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$G,$v_1.$0_0,Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$H)]=$v_0};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$S=function($p0){var $v_0=$get("rofContainer");$v_0.style.top="0px";var $v_1=$get("mainContainer");$v_1.style.left="23px";var $v_2=$get("tdAreas"),$v_3=$v_2.scrollHeight+"px";$p0.style.height=$v_3;$v_2.style.height="100%";$v_2.className="ms-crm-Form-AreaContainerQuick  ms-crm-Form-Background"};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$6=function($p0){var $v_0=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$E();if(!IsNull($v_0)&&!IsNull($p0)){$v_0[String.format(Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$G,$p0,Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$H)]=null;$p0=null}};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$E=function(){var $v_0=window.parent,$v_1=$v_0.parent;while($v_1!==$v_0){$v_0=$v_1;$v_1=$v_0.parent}return $v_1};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$F=function(){var $v_0=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$E();return $v_0.document};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$2=function(){var $v_0=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$F();return $v_0.body};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$b=function(){for(var $v_0=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$F(),$v_1=$v_0.getElementsByTagName("iframe"),$v_2=0;$v_2<$v_1.length;$v_2++){var $v_3=$v_1[$v_2],$v_4=null;try{$v_4=!IsNull($v_3.contentDocument)?$v_3.contentDocument:$v_3.contentWindow.document}catch($$e_5){continue}if($v_4===window.document)return $v_3}return null};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$7=function($p0){var $v_0=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$E();if($v_0){var $v_1=$v_0[String.format(Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$G,$p0,Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$H)];return $v_1}return null};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$n=function($p0,$p1,$p2,$p3,$p4,$p5,$p6,$p7,$p8){Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$R($p0.$0_0,$p0.$5_0);Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$Q($p0.$0_0,$p0.$5_0);var $v_0=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$U($p0.$0_0,$p1,$p0.$5_0,$p4),$v_1=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$V($p0.$0_0,$p4,$p5);$v_0.style.top=40+"px";var $v_2=new Sys.StringBuilder;if(!IsNull($p3)){var $$dict_C=$p3;for(var $$key_D in $$dict_C){var $v_5={key:$$key_D,value:$$dict_C[$$key_D]};$v_2.append(String.format(Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$O,$v_5.key,$v_5.value))}}var $v_3=String.format("/_forms/read/page.aspx?showglobalquickcreate=true&etc={0}&setLastViewed=false&hidecommandbar=true{1}&_CreateFromId={2}&_CreateFromType={3}&_searchText={4}",$p2,$v_2.toString(),$p6,$p7,$p8),$v_4=Mscrm.CrmUri.create($v_3);$v_1.src=$v_4.toString();window.self.QuickCreateIFrameLoadingStartTime=(new Date).getTime()};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$V=function($p0,$p1,$p2){var $v_0=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$e($p0,$p1),$v_1=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$2();$v_1.insertBefore($v_0,XUI.Html.DomUtils.GetFirstChild($v_1));var $v_2=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$k($p0,$p2);$v_0.appendChild($v_2);var $v_3=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$c($p0);$v_0.appendChild($v_3);return $v_2};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$c=function($p0){var $v_0=document.createElement(Mscrm.ElementNames.div);$v_0.className="mscrm-globalqc-actionsdiv";var $v_1=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$l($p0);$v_0.appendChild($v_1);var $v_2=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$d($p0);$v_0.appendChild($v_2);return $v_0};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$l=function($p0){var $v_0=document.createElement(Mscrm.ElementNames.button);$v_0.id=CrmEncodeDecode.CrmHtmlAttributeEncode(String.format("globalquickcreate_save_button_{0}",$p0));$v_0.className="mscrm-globalqc-actionbutton";$v_0.setAttribute(Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$D,CrmEncodeDecode.CrmHtmlAttributeEncode($p0));$addHandler($v_0,"click",Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$N);$v_0.appendChild(document.createTextNode(window.LOCID_SAVE_GLOBAL_QUICKCREATE));return $v_0};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$N=function($p0){var $v_0=Mscrm.Utilities.getDomEventElement($p0,Mscrm.ElementNames.button),$v_1=$v_0.getAttribute(Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$D),$v_2=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$7($v_1),$v_3=$v_2.onRefreshFormSaveCallback;Mscrm.Utilities.executeFunction($v_3,null)};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.closeAllGlobalQuickCreateForms=function(){var $v_0=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.allQuickForms();$v_0.each(function($p1_0,$p1_1){var $v_1=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$7($p1_1.id);Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$J($v_1,$p1_1.id)})};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.allQuickForms=function(){var $v_0=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$F(),$v_1=$P_CRM($v_0),$v_2=$v_1.find(".mscrm-globalqc-iframe");return $v_2};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$d=function($p0){var $v_0=document.createElement(Mscrm.ElementNames.button);$v_0.id=CrmEncodeDecode.CrmHtmlAttributeEncode(String.format("globalquickcreate_cancel_button_{0}",$p0));$v_0.className="mscrm-globalqc-actionbutton mscrm-globalqc-actionbutton-last";$v_0.setAttribute(Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$D,CrmEncodeDecode.CrmHtmlAttributeEncode($p0));$addHandler($v_0,"click",Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$K);$v_0.appendChild(document.createTextNode(window.LOCID_CANCEL_GLOBAL_QUICKCREATE));return $v_0};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$K=function($p0){var $v_0=Mscrm.Utilities.getDomEventElement($p0,Mscrm.ElementNames.button),$v_1=$v_0.getAttribute(Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$D),$v_2=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$7($v_1);Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$J($v_2,$v_1)};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$k=function($p0,$p1){var $v_0=document.createElement(Mscrm.ElementNames.iFrame);$v_0.className="mscrm-globalqc-iframe";$v_0.id=CrmEncodeDecode.CrmHtmlAttributeEncode($p0);if(!isNullOrEmptyString($p1))$v_0.style.height=$p1;if(Mscrm.Utilities.isIE8())$v_0.frameBorder="0";return $v_0};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$e=function($p0,$p1){var $v_0=document.createElement(Mscrm.ElementNames.div);$v_0.id=CrmEncodeDecode.CrmHtmlAttributeEncode(String.format("globalquickcreate_container_{0}",$p0));$v_0.className="mscrm-globalqc-containerdiv ms-crm-HighContrastMode-Border";$v_0.style.position="absolute";$v_0.style.top="-1000px";$v_0.style.zIndex=-1e3;$v_0.style.width=!isNullOrEmptyString($p1)?$p1:"100%";return $v_0};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$U=function($p0,$p1,$p2,$p3){var $v_0=document.createElement(Mscrm.ElementNames.div);$v_0.id=CrmEncodeDecode.CrmHtmlAttributeEncode(String.format("globalquickcreate_entityinfo_{0}",$p0));$v_0.className="mscrm-globalqc-parentdiv ms-crm-HighContrastMode-Border";$v_0.style.width=!isNullOrEmptyString($p3)?$p3:"100%";var $v_1=document.createElement(Mscrm.ElementNames.div);$v_1.className="mscrm-globalqc-entitycrossdiv";$v_0.appendChild($v_1);var $v_2=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$j($p0);$v_1.appendChild($v_2);var $v_3=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$g($p1);$v_1.appendChild($v_3);var $v_4=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$f($p0);$v_1.appendChild($v_4);var $v_5=document.createElement(Mscrm.ElementNames.div);$v_5.className="mscrm-globalqc-cleardiv";$v_1.appendChild($v_5);var $v_6=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$h($p0);$v_1.appendChild($v_6);$v_0.style.zIndex=$p2+2;var $v_7=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$2();$v_7.insertBefore($v_0,XUI.Html.DomUtils.GetFirstChild($v_7));return $v_0};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$h=function($p0){var $v_0=document.createElement(Mscrm.ElementNames.div);$v_0.id=CrmEncodeDecode.CrmHtmlAttributeEncode(String.format("globalquickcreate_error_message_{0}",$p0));$v_0.className="mscrm-globalqc-errormessage";$v_0.style.display="none";var $v_1=document.createElement(Mscrm.ElementNames.image);$v_1.src="/_imgs/inlineedit/warning.png";$v_1.style.verticalAlign="middle";$v_0.appendChild($v_1);var $v_2=document.createElement(Mscrm.ElementNames.span);$v_2.className="mscrm-globalqc-warningmessage";$v_0.appendChild($v_2);return $v_0};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$j=function($p0){var $v_0=document.createElement(Mscrm.ElementNames.image);$v_0.id=CrmEncodeDecode.CrmHtmlAttributeEncode(String.format("globalquickcreate_loading_bar_{0}",$p0));$v_0.src="/_imgs/progressbar.gif";$v_0.className="mscrm-globalqc-loadingBar";return $v_0};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$Q=function($p0,$p1){var $v_0=document.createElement(Mscrm.ElementNames.div);$v_0.id=CrmEncodeDecode.CrmHtmlAttributeEncode(String.format("globalquickcreate_overlay_{0}",$p0));$v_0.className="ms-crm-InlineDialogBackground";$v_0.style.zIndex=$p1;$v_0.style.display="block";XUI.Html.SetOpacity($v_0,.5);var $v_1=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$2();$v_1.insertBefore($v_0,XUI.Html.DomUtils.GetFirstChild($v_1))};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$f=function($p0){var $v_0=document.createElement(Mscrm.ElementNames.div);$v_0.className="mscrm-globalqc-cross";var $v_1=document.createElement(Mscrm.ElementNames.anchor);$v_1.id=CrmEncodeDecode.CrmHtmlAttributeEncode(String.format("globalquickcreate_cross_anchor_{0}",$p0));$v_1.className="mscrm-globalqc-cross";$v_0.appendChild($v_1);$v_1.setAttribute(Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$I,CrmEncodeDecode.CrmHtmlAttributeEncode($p0));$v_1.href="javascript:void(0);";$v_1.title=window.LOCID_CLOSE_GLOBAL_QUICKCREATE;$addHandler($v_1,"click",Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$L);$addHandler($v_1,"keydown",Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$M);var $v_2=document.createElement(Mscrm.ElementNames.image);$v_2.className="mscrm-globalqc-cross";$v_1.appendChild($v_2);$v_2.src="/_imgs/refreshCommandBar/Close_16.png";return $v_0};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$g=function($p0){var $v_0=document.createElement(Mscrm.ElementNames.div);$v_0.appendChild(document.createTextNode($p0));$v_0.className="mscrm-globalqc-entityname";return $v_0};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$L=function($p0){var $v_0=Mscrm.Utilities.getDomEventElement($p0,Mscrm.ElementNames.anchor),$v_1=$v_0.getAttribute(Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$I),$v_2=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$F(),$v_3=$P_CRM($v_2);$v_3.find("#"+CrmEncodeDecode.CrmHtmlAttributeEncode($v_1)).stop();var $v_4=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$7($v_1);Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$W($v_4,$v_1)};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$M=function($p0){var $v_0=Mscrm.Utilities.getDomEventElement($p0,Mscrm.ElementNames.anchor),$v_1=$v_0.getAttribute(Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$I),$v_2=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$F(),$v_3=$P_CRM($v_2),$v_4=$v_3.find("#"+CrmEncodeDecode.CrmHtmlAttributeEncode($v_1))[0];if($p0.keyCode===9&&!$p0.shiftKey){$p0.stopPropagation();$p0.preventDefault();var $v_5=Mscrm.InlineDialogUtility.findFirstFocusableElement($v_4.contentDocument.body);!IsNull($v_5)&&$v_5.focus()}};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$R=function($p0,$p1){var $v_0=document.createElement(Mscrm.ElementNames.div);$v_0.id=CrmEncodeDecode.CrmHtmlAttributeEncode(String.format("navbar_overlay_{0}",$p0));$v_0.className="ms-crm-InlineDialogBackground";$v_0.style.zIndex=$p1+14;$v_0.style.height=40+"px";$v_0.style.display="block";XUI.Html.SetOpacity($v_0,.5);var $v_1=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$2();$v_1.insertBefore($v_0,XUI.Html.DomUtils.GetFirstChild($v_1))};Mscrm.GlobalQuickCreate.GlobalQuickCreateCallbacks=function(quickCreateFrameId,zIndex){this.$$d_$m_0=Function.createDelegate(this,this.$m_0);this.$0_0=quickCreateFrameId;this.$5_0=parseInt(zIndex.toString(),10)};Mscrm.GlobalQuickCreate.GlobalQuickCreateCallbacks.prototype={get_quickCreateFrameId:function(){return this.$0_0},get_zIndex:function(){return this.$5_0},get_callbackDictionary:function(){var $v_0={};$v_0["onQuickCreateLoadCallback"]=Mscrm.Utilities.createCallbackFunctionObject("onQuickCreateLoadCallback",this,null,false);$v_0["onQuickCreateSaveSuccessCallback"]=Mscrm.Utilities.createCallbackFunctionObject("onQuickCreateSaveSuccessCallback",this,null,false);$v_0["onQuickCreateCancelCallback"]=Mscrm.Utilities.createCallbackFunctionObject("onQuickCreateCancelCallback",this,null,false);$v_0["onQuickCreateSaveFailCallback"]=Mscrm.Utilities.createCallbackFunctionObject("onQuickCreateSaveFailCallback",this,null,false);$v_0["onQuickCreateSaveInitiatedCallback"]=Mscrm.Utilities.createCallbackFunctionObject("onQuickCreateSaveInitiatedCallback",this,null,false);$v_0["onQuickCreateStopLoadCallback"]=Mscrm.Utilities.createCallbackFunctionObject("onQuickCreateStopLoadCallback",this,null,false);return $v_0},onQuickCreateLoadCallback:function(){var $v_0=$get(CrmEncodeDecode.CrmHtmlAttributeEncode(String.format("globalquickcreate_loading_bar_{0}",this.$0_0)),this.get_entityInfoObject()[0]);$v_0.style.visibility="hidden";this.get_entityInfoObject().css("box-shadow","none");this.get_containerObject()[0].style.top=String.format("-{0}px",this.get_containerObject().height());this.get_containerObject()[0].style.zIndex=this.$5_0+1;this.$T_0(this.$0_0);var $v_1={};$v_1["top"]=40+this.get_entityInfoObject().height()+"px";window.self.QuickCreateFormLoadEndTime=(new Date).getTime();this.get_containerObject().animate($v_1,"slow")},$T_0:function($p0){this.$4_0=this.$i_0($p0);if(!IsNull(this.$4_0)){this.$4_0.focus();$addHandler(this.$4_0,"keydown",this.$$d_$m_0)}},$i_0:function($p0){var $v_0=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$2(),$v_1=$get(CrmEncodeDecode.CrmHtmlAttributeEncode($p0),$v_0);if(!IsNull($v_1)){var $v_2=$v_1.contentDocument.body,$v_3=Mscrm.InlineDialogUtility.findFirstFocusableElement($v_2);$v_2.setAttribute("tabindex",-1);return $v_3}return null},$m_0:function($p0){if($p0.keyCode===9&&$p0.shiftKey){var $v_0=$get(CrmEncodeDecode.CrmHtmlAttributeEncode(String.format("globalquickcreate_cross_anchor_{0}",this.$0_0)),this.get_entityInfoObject()[0]);$p0.stopPropagation();$p0.preventDefault();$v_0.focus()}},onQuickCreateStopLoadCallback:function(){var $$t_0=this;this.hideQuickCreateWithAnimation(function(){$$t_0.removeEntireGlobalQuickCreateFromDom()});return true},onQuickCreateSaveSuccessCallback:function(record){var $$t_1=this;this.hideQuickCreateWithAnimation(function(){$$t_1.removeEntireGlobalQuickCreateFromDom()});return true},onQuickCreateSaveFailCallback:function(jsonData){var $v_0=$get(CrmEncodeDecode.CrmHtmlAttributeEncode(String.format("globalquickcreate_loading_bar_{0}",this.$0_0)),this.get_entityInfoObject()[0]);$v_0.style.visibility="hidden";var $v_1=$get(CrmEncodeDecode.CrmHtmlAttributeEncode(String.format("globalquickcreate_save_button_{0}",this.$0_0)),this.get_containerObject()[0]),$v_2=$P_CRM($v_1);$v_2.attr("disabled")=="disabled"&&$v_2.removeAttr("disabled");var $v_3=jsonData["_error"],$v_4=$v_3["DisplayText"];IsNull($v_3["Code"])&&!isNullOrEmptyString($v_4)&&this.$P_0(true,$v_4);return false},onQuickCreateCancelCallback:function(){var $$t_0=this;this.hideQuickCreateWithAnimation(function(){$$t_0.removeEntireGlobalQuickCreateFromDom()});return true},onQuickCreateSaveInitiatedCallback:function(){var $v_0=$get(CrmEncodeDecode.CrmHtmlAttributeEncode(String.format("globalquickcreate_loading_bar_{0}",this.$0_0)),this.get_entityInfoObject()[0]);$v_0.style.visibility="visible";var $v_1=$get(CrmEncodeDecode.CrmHtmlAttributeEncode(String.format("globalquickcreate_save_button_{0}",this.$0_0)),this.get_containerObject()[0]),$v_2=$P_CRM($v_1);$v_2.attr("disabled","disabled");this.$P_0(false,null);return false},hideQuickCreateWithAnimation:function(afterAnimateCallback){var $$t_1=this;this.get_containerObject().slideUp(250,function(){$$t_1.get_entityInfoObject().slideUp(250,function(){$$t_1.get_overlayObject().hide();afterAnimateCallback()})})},$P_0:function($p0,$p1){var $v_0=$get(CrmEncodeDecode.CrmHtmlAttributeEncode(String.format("globalquickcreate_error_message_{0}",this.$0_0)),this.get_entityInfoObject()[0]),$v_1=$P_CRM($v_0);if($p0){$P_CRM("span",$v_1).text($p1);$v_1.show()}else $v_1.hide();var $v_2={};$v_2["top"]=40+this.get_entityInfoObject().height()+"px";this.get_containerObject().animate($v_2,"fast")},get_entityInfoObject:function(){if(IsNull(this.$9_0)){var $v_0=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$2(),$v_1=$get(CrmEncodeDecode.CrmHtmlAttributeEncode(String.format("globalquickcreate_entityinfo_{0}",this.$0_0)),$v_0);this.$9_0=$P_CRM($v_1)}return this.$9_0},get_overlayObject:function(){if(IsNull(this.$C_0)){var $v_0=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$2(),$v_1=$get(CrmEncodeDecode.CrmHtmlAttributeEncode(String.format("globalquickcreate_overlay_{0}",this.$0_0)),$v_0);this.$C_0=$P_CRM($v_1)}return this.$C_0},get_containerObject:function(){if(IsNull(this.$8_0)){var $v_0=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$2(),$v_1=$get(CrmEncodeDecode.CrmHtmlAttributeEncode(String.format("globalquickcreate_container_{0}",this.$0_0)),$v_0);this.$8_0=$P_CRM($v_1)}return this.$8_0},get_iFrameObject:function(){if(IsNull(this.$A_0)){var $v_0=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$2(),$v_1=$get(CrmEncodeDecode.CrmHtmlAttributeEncode(this.$0_0),$v_0);this.$A_0=$P_CRM($v_1)}return this.$A_0},get_navBarOverlayObject:function(){if(IsNull(this.$B_0)){var $v_0=Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$2(),$v_1=$get(CrmEncodeDecode.CrmHtmlAttributeEncode(String.format("navbar_overlay_{0}",this.$0_0)),$v_0);this.$B_0=$P_CRM($v_1)}return this.$B_0},removeEntireGlobalQuickCreateFromDom:function(){var $$t_0=this;window.setTimeout(function(){Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.removeGlobalQuickCreateAttachedEvents($$t_0.$0_0);!IsNull($$t_0.$4_0)&&$removeHandler($$t_0.$4_0,"keydown",$$t_0.$$d_$m_0);if(!IsNull($$t_0.get_containerObject())&&$$t_0.get_containerObject().length){if(!IsNull($$t_0.get_iFrameObject())&&$$t_0.get_iFrameObject().length){$$t_0.get_iFrameObject().empty().remove();$$t_0.$A_0=null}$$t_0.get_containerObject().empty().remove();$$t_0.$8_0=null}if(!IsNull($$t_0.get_entityInfoObject())&&$$t_0.get_entityInfoObject().length){$$t_0.get_entityInfoObject().empty().remove();$$t_0.$9_0=null}if(!IsNull($$t_0.get_overlayObject())&&$$t_0.get_overlayObject().length){$$t_0.get_overlayObject().empty().remove();$$t_0.$C_0=null}if(!IsNull($$t_0.get_navBarOverlayObject())&&$$t_0.get_navBarOverlayObject().length){$$t_0.get_navBarOverlayObject().empty().remove();$$t_0.$B_0=null}$$t_0.$8_0=null;$$t_0.$A_0=null;$$t_0.$9_0=null;$$t_0.$C_0=null;$$t_0.$B_0=null},0)},$0_0:null,$5_0:0,$9_0:null,$C_0:null,$8_0:null,$A_0:null,$B_0:null,$4_0:null};Mscrm.GlobalQuickCreate.RefreshFormCallbacks=function(quickCreateFrameId){this.$$d_$o_0=Function.createDelegate(this,this.$o_0);this.$0_0=quickCreateFrameId};Mscrm.GlobalQuickCreate.RefreshFormCallbacks.$p=function($p0){var $v_0=Mscrm.InlineEditUtilities.getEntityReference($p0);Mscrm.InlineEditDataService.refreshGridOnStateChange();Mscrm.InlineEditDataService.set_primaryEntityChange(false);Mscrm.InlineEditUtilities.addEntityToRecent($v_0);Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.executeCallbacksAssociatedWithGlobalQuickCreate("savesuccess",$v_0);return true};Mscrm.GlobalQuickCreate.RefreshFormCallbacks.prototype={$0_0:null,get_quickCreateFrameId:function(){return this.$0_0},get_callbackDictionary:function(){var $v_0={};$v_0["onRefreshFormSaveCallback"]=Mscrm.Utilities.createCallbackFunctionObject("onRefreshFormSaveCallback",this,null,false);return $v_0},onRefreshFormSaveCallback:function(){Mscrm.InlineEditUtilities.tryResetFocusOnActiveControl();var $v_0=Mscrm.InlineEditDataService.save(Xrm.SaveMode.save,Mscrm.GlobalQuickCreate.RefreshFormCallbacks.$p,this.$$d_$o_0,false);if($v_0.get_success())$v_0.get_code()===Mscrm.SaveResponseCode.saveSuccessfullyInitiated&&Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.executeCallbacksAssociatedWithGlobalQuickCreate("saveinitiated");else{var $v_1={};$v_1["DisplayText"]=$v_0.get_message();var $v_2={};$v_2["_error"]=$v_1;Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.executeCallbacksAssociatedWithGlobalQuickCreate("savefailure",$v_2)}},$o_0:function($p0){Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.executeCallbacksAssociatedWithGlobalQuickCreate("savefailure",$p0);return false}};Mscrm.GlobalQuickCreate.QuickCreateCallbackType=function(){};Mscrm.GlobalQuickCreate.GlobalQuickCreateLayoutZIndexOrder=function(){};Mscrm.GlobalQuickCreate.LookupGlobalQuickCreateCallbacks=function(quickCreateFrameId,zIndex,saveCallback){Mscrm.GlobalQuickCreate.LookupGlobalQuickCreateCallbacks.initializeBase(this,[quickCreateFrameId,zIndex]);this.$3_1=saveCallback};Mscrm.GlobalQuickCreate.LookupGlobalQuickCreateCallbacks.prototype={$3_1:null,onQuickCreateSaveSuccessCallback:function(record){var $$t_1=this;this.hideQuickCreateWithAnimation(function(){!IsNull($$t_1.$3_1)&&$$t_1.$3_1(record);$$t_1.removeEntireGlobalQuickCreateFromDom()});return true}};Mscrm.GlobalQuickCreate.CreateChildCaseGlobalQuickCreateCallbacks=function(quickCreateFrameId,zIndex,saveCallback){Mscrm.GlobalQuickCreate.CreateChildCaseGlobalQuickCreateCallbacks.initializeBase(this,[quickCreateFrameId,zIndex]);this.$3_1=saveCallback};Mscrm.GlobalQuickCreate.CreateChildCaseGlobalQuickCreateCallbacks.prototype={$3_1:null,onQuickCreateSaveSuccessCallback:function(record){var $$t_1=this;this.hideQuickCreateWithAnimation(function(){!IsNull($$t_1.$3_1)&&$$t_1.$3_1(record);$$t_1.removeEntireGlobalQuickCreateFromDom()});return true}};Mscrm.GlobalQuickCreate.GridControlGlobalQuickCreateCallbacks=function(quickCreateFrameId,zIndex,saveCallback){Mscrm.GlobalQuickCreate.GridControlGlobalQuickCreateCallbacks.initializeBase(this,[quickCreateFrameId,zIndex]);this.$3_1=saveCallback};Mscrm.GlobalQuickCreate.GridControlGlobalQuickCreateCallbacks.prototype={$3_1:null,onQuickCreateSaveSuccessCallback:function(record){var $$t_1=this;this.hideQuickCreateWithAnimation(function(){!IsNull($$t_1.$3_1)&&$$t_1.$3_1();$$t_1.removeEntireGlobalQuickCreateFromDom()});return true}};Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.registerClass("Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior");Mscrm.GlobalQuickCreate.GlobalQuickCreateCallbacks.registerClass("Mscrm.GlobalQuickCreate.GlobalQuickCreateCallbacks");Mscrm.GlobalQuickCreate.RefreshFormCallbacks.registerClass("Mscrm.GlobalQuickCreate.RefreshFormCallbacks");Mscrm.GlobalQuickCreate.QuickCreateCallbackType.registerClass("Mscrm.GlobalQuickCreate.QuickCreateCallbackType");Mscrm.GlobalQuickCreate.GlobalQuickCreateLayoutZIndexOrder.registerClass("Mscrm.GlobalQuickCreate.GlobalQuickCreateLayoutZIndexOrder");Mscrm.GlobalQuickCreate.LookupGlobalQuickCreateCallbacks.registerClass("Mscrm.GlobalQuickCreate.LookupGlobalQuickCreateCallbacks",Mscrm.GlobalQuickCreate.GlobalQuickCreateCallbacks);Mscrm.GlobalQuickCreate.CreateChildCaseGlobalQuickCreateCallbacks.registerClass("Mscrm.GlobalQuickCreate.CreateChildCaseGlobalQuickCreateCallbacks",Mscrm.GlobalQuickCreate.GlobalQuickCreateCallbacks);Mscrm.GlobalQuickCreate.GridControlGlobalQuickCreateCallbacks.registerClass("Mscrm.GlobalQuickCreate.GridControlGlobalQuickCreateCallbacks",Mscrm.GlobalQuickCreate.GlobalQuickCreateCallbacks);Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.globalQuickCreateEntityInfoDivIdFormat="globalquickcreate_entityinfo_{0}";Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.globalQuickCreateOverlayIdFormat="globalquickcreate_overlay_{0}";Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.globalQuickCreateLoadingBarIdFormat="globalquickcreate_loading_bar_{0}";Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.globalQuickCreateErrorMessageIdFormat="globalquickcreate_error_message_{0}";Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.globalQuickCreateSaveButtonIdFormat="globalquickcreate_save_button_{0}";Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.globalQuickCreateCancelButtonIdFormat="globalquickcreate_cancel_button_{0}";Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.globalQuickCreateContainerDivIdFormat="globalquickcreate_container_{0}";Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.globalQuickCreateCrossAnchorIdFormat="globalquickcreate_cross_anchor_{0}";Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.navBarOverlayIdFormat="navbar_overlay_{0}";Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.navigationControlHeight=40;Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$H="_quickCreateArgumentsKey";Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$G="{1}_{2}";Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$I="anchor_quickiframe_id";Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$D="button_quickiframe_id";Mscrm.GlobalQuickCreate.GlobalQuickCreateBehavior.$O="&{0}={1}";Mscrm.GlobalQuickCreate.GlobalQuickCreateCallbacks.onQuickCreateLoadCallbackFuncName="onQuickCreateLoadCallback";Mscrm.GlobalQuickCreate.GlobalQuickCreateCallbacks.onQuickCreateSaveSuccessCallbackFuncName="onQuickCreateSaveSuccessCallback";Mscrm.GlobalQuickCreate.GlobalQuickCreateCallbacks.onQuickCreateSaveFailCallbackFuncName="onQuickCreateSaveFailCallback";Mscrm.GlobalQuickCreate.GlobalQuickCreateCallbacks.onQuickCreateCancelCallbackFuncName="onQuickCreateCancelCallback";Mscrm.GlobalQuickCreate.GlobalQuickCreateCallbacks.onQuickCreateSaveInitiatedCallbackFuncName="onQuickCreateSaveInitiatedCallback";Mscrm.GlobalQuickCreate.GlobalQuickCreateCallbacks.onQuickCreateStopLoadCallbackFuncName="onQuickCreateStopLoadCallback";Mscrm.GlobalQuickCreate.RefreshFormCallbacks.onRefreshFormSaveCallbackFuncName="onRefreshFormSaveCallback";Mscrm.GlobalQuickCreate.QuickCreateCallbackType.open="open";Mscrm.GlobalQuickCreate.QuickCreateCallbackType.saveSuccess="savesuccess";Mscrm.GlobalQuickCreate.QuickCreateCallbackType.saveFail="savefailure";Mscrm.GlobalQuickCreate.QuickCreateCallbackType.saveInitiated="saveinitiated";Mscrm.GlobalQuickCreate.QuickCreateCallbackType.cancel="cancel";Mscrm.GlobalQuickCreate.GlobalQuickCreateLayoutZIndexOrder.overlay=0;Mscrm.GlobalQuickCreate.GlobalQuickCreateLayoutZIndexOrder.quickCreateIFrame=1;Mscrm.GlobalQuickCreate.GlobalQuickCreateLayoutZIndexOrder.quickCreateEntityInfoDiv=2;Mscrm.GlobalQuickCreate.GlobalQuickCreateLayoutZIndexOrder.navBarOverlay=14