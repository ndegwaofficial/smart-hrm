﻿
$(document).ready(function () {
            
    $.ajax({
        url: "/Admin/EmployeeTermination/GetAll",
        type: "GET",

        success: function (data) {
            //alert(data);

            var table = $("#approveterminationtblbody tbody");
            var employeeId = 0;
            table.empty();
            $.each(data.data, function (i, item) {
                table.append(`<tr><td>` + item.employee.fullNameWithCode + `</td><td class="align-middle">` + item.employee.designation + `</td><td class="align - middle">` + item.terminationCategory.name + `</td><td class="align - middle">` + item.termDate + `</td><td class="align - middle">` + item.approvalStatus +
                    `<td class="fs--1 align-middle">
                                            <input class="form-check-input" id = "${item.id}" value="${item.id}" name="chkBox" type="checkbox" data-bulk-select-row="{&quot;name&quot;:&quot;Anna&quot;,&quot;email&quot;:&quot;anna@example.com&quot;,&quot;age&quot;:18}" />
                                        </td>`
                    + "</tr>");
                       
            });
                  
                 
        }

    });
      


          // add multiple select / deselect functionality
     $("#bulk-select-example").click(function () {
        $('.form-check-input').attr('checked', this.checked);
        //alert('I am here');
    });


    // if all checkbox are selected, check the selectall checkbox     // and viceversa
    $(".form-check-input").click(function () {
        if ($(".form-check-input").length == $(".form-check-input:checked").length) {
            $("#bulk-select-example").attr("checked", "checked");
        }
        else {
            $("#bulk-select-example").removeAttr("checked");
        }
    });

   

    //Post Data

    document.getElementById('btnpostdata').addEventListener('click', 
    function(event) { 
        //event.preventDefault();       
        //debugger
        let ids = [];
        var table = $('#approveterminationtblbody').DataTable();
        if ($('[name="chkBox"]:checked').length <= 0) {
            alert('Please select minimum one data');
            exit();
        }
        else {
          
            $('[name="chkBox"]:checked').each(function (data) {
                ids.push($(this).val());          
             });
            
             $.ajax({
                 url: '/Admin/EmployeeTermination/ApproveTermination',
                type: 'POST',              
                dataType: 'json',               
                data: JSON.stringify(ids),
                contentType: 'application/json; charset=utf-8',       
                 success: function (data) {              
                     alert('Finally here now');
                     window.location.href = "EmployeeTermination/Index";
                 },
                 error: function (e) {
                     console.log('--error--')
                     
                 }
             }); 
 
        }
      });

});
    

