// JScript File
function chkAllBox(cmb, name_f, name_b)
{
    var i = 2;
    var itxt = '00' + i;
    //alert(name_f + twonum(i) + name_b);
    while ( document.getElementById(name_f + (i < 100 ? itxt.substring(itxt.length - 2, itxt.length) : itxt) + name_b) != null)
    {
        zctl = document.getElementById(name_f + (i < 100 ? itxt.substring(itxt.length - 2, itxt.length) : itxt) + name_b)
        if (zctl.disabled == '') zctl.checked = cmb.checked;
        i++;
        itxt = (i < 100 ? '00' : '') + i;
    }
}
function ChkMinusDbl(ctl, e) {
    //var evt = e ? e : window.event;
    var zz = e.keyCode || e.charCode;
    
    if (zz < 48 || zz > 57) {
        if (zz == 46) {
            if (ctl.value.indexOf(".", 0) >= 0) {
//                if(window.event)//IE
//                    event.returnValue = false;
//                else //Firefox
//                    e.preventDefault();
                e.preventDefault();
            }
        }
        else {
//            if (window.event)//IE
//                event.returnValue = false;
//            else  //Firefox
//                e.preventDefault();
            e.preventDefault();
        }

    }
}

function ChkMinusInt(ctl, e) {
    //var evt = e ? e : window.event;
    var zz = e.keyCode || e.charCode;

    if (zz < 48 || zz > 57) {
//        alert(zz);
//        if(window.event)
//            event.returnValue = false;
//        else
//            e.preventDefault();
        e.preventDefault();
    }
}

function CheckKeyNumber(e) {
    //ป้องกันการกดปุ่ม  ctrl และปุ่มตัว V
    var evt = e ? e : window.event;
    var keyCode = evt.keyCode || evt.charCode;
    
    if ((keyCode == 17) || (keyCode == 86)) {
//        if (window.event)//IE
//            event.returnValue = false;
//        else if (e)//Firefox
//            e.preventDefault();
        e.preventDefault();
    }
}

function DisableText(ctl)
{
    event.returnValue = false;
}

function txtTime_OnKeyPress(sender,e) {
    var evt = e ? e : window.event;
    var charCode = evt.keyCode || evt.charCode;

    //var charCode = (event.which) ? event.which : event.keyCode
    //alert(charCode);
    if ((charCode != 8) && (charCode != 46)) {
        
        var myTime = sender.value;
        if (myTime.length > 4) {
//            if (window.event)
//                event.returnValue = false;
//            else
//                e.preventDefault();
            e.preventDefault();
        }

        switch (myTime.length) {
            case 0:
                if (charCode < 48 || charCode > 50) {
//                    if (window.event)
//                        event.returnValue = false;
//                    else
//                        e.preventDefault();
                    e.preventDefault();
                }
                break;
            case 1:
                if (myTime == 2) {
                    if (charCode > 51) {
//                        if (window.event)
//                            event.returnValue = false;
//                        else
//                            e.preventDefault();
                        e.preventDefault();
                    }
                } else {
                    if (charCode < 48 || charCode > 57) {
//                        if (window.event)
//                            event.returnValue = false;
//                        else
//                            e.preventDefault();
                        e.preventDefault();
                    }
                }
                break;
            case 2:
                {
                    if (charCode < 48 || charCode > 53) {
//                        if (window.event)
//                            event.returnValue = false;
//                        else
//                            e.preventDefault();
                        e.preventDefault();
                    }
                    sender.value = sender.value + ':';
                }
                break;
            case 3:
                if (charCode < 48 || charCode > 53) {
                    if (window.event)
                        event.returnValue = false;
                    else
                        e.preventDefault();
                }
                //alert(3);
                break;
            default:
                if (charCode < 48 || charCode > 57) {
//                    if (window.event)
//                        event.returnValue = false;
//                    else
//                        e.preventDefault();
                    e.preventDefault();
                }
        }
    }
}

function ValidateTime(sender) {
    if (sender.value.length == 0) return false;
    var regEx = /^(\d{2}):(\d{2})$/;
    var arrMatch = sender.value.match(regEx);
    if (arrMatch == null) {
        alert("Invalid time.");
        sender.value = "";
        return false;
    }
    var hh = arrMatch[1];
    var mm = arrMatch[2];
    if (hh >= 24 || mm >= 60) {
        alert("Invalid time.");
        sender.value = "";
        return false;
    }
    return true;
}


function CheckKeyBackSpace(e) {
//ป้องกันการกดปุ่ม Delete , ปุ่ม Backspace , ปุ่ม ctrl และปุ่มตัว V
    //var keyCode = (event.which) ? event.which : event.keyCode;
    var evt = e ? e : window.event;
    var keyCode = evt.keyCode;
    if ((keyCode == 8) || (keyCode == 46) || (keyCode == 17) || (keyCode == 86)) {
//        if(window.event)//IE
//            event.returnValue = false;
//        else if(e)//Firefox
//            e.preventDefault();
        e.preventDefault();
    }
}


function txtKeyPress(e) {
//    if(window.event)//For IE
//        event.returnValue = false;
//    else if(e)//For Firefox
//        e.preventDefault();
    e.preventDefault();
}

function clickButton(e, buttonid) {
    var evt = e ? e : window.event;
    var bt = document.getElementById(buttonid);
    if (bt) {
        if (evt.keyCode == 13) {
            bt.click();
            return false;
        }
    }
}