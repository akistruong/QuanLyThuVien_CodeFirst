// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
handleHideElement = (element, opt) => {
    element.css('display', opt)
}
const handleAddToCart = () => {
    let _id = 0;
        $(".btnAddToCart").click((e) => {
            _id = e.target.getAttribute("_id");
            $.post("/Cart/AddToCart", { id: _id }, (data, err) => {
                if (data.success) {
                    var countString = $("#badge").html();
                    $("#badge").html(Number(countString) + 1)
                }
            })

        })
}
const handleUpdateQtyCart = (id,qty,ElementTotalPrice,ElementFinalPrice) => {
    
    $.post("/cart/UpdateQty", { id, qty }, (data, err) => {
        if (data.success) {
            ElementTotalPrice.html(formatVnd(data.item.total).toString())
            ElementFinalPrice.html(formatVnd(data.finalPrice).toString())
            $("#badge").html(parseFloat(data.qty))
        }
    })

       
}
const handleRemoveCartItem = (id,element) => {
    
    $.post("/cart/DeleteCart", { id }, (data, err) => {
        if (data.success) {
            let oldValue = parseFloat($("#badge").html()) ;
            $("#badge").html(`${oldValue - data.qtyDelete}`)
            element.remove();
            let oldPrice = $("#finalPrice").attr("price");
            
            let newPrice = oldPrice- data.item.total ;
            $("#finalPrice").html(`${formatVnd(newPrice)}`)
            $("#finalPrice").attr("price", newPrice);
        }
    })
}
const formatVnd = (s) => {
   return new Intl.NumberFormat('vi-VN', { style: 'currency', currency: 'VND' }).format(s)
}

const formatSlug = (s) => {
    s = s.toLowerCase()
    s = s
        .normalize('NFD') // chuyển chuỗi sang unicode tổ hợp
        .replace(/[\u0300-\u036f]/g, ''); // xóa các ký tự dấu sau khi tách tổ hợp

    // Thay ký tự đĐ
    s = s.replace(/[đĐ]/g, 'd');

    // Xóa ký tự đặc biệt
    s = s.replace(/([^0-9a-z-\s])/g, '');

    // Xóa khoảng trắng thay bằng ký tự -
    s = s.replace(/(\s+)/g, '-');

    // Xóa ký tự - liên tiếp
    s = s.replace(/-+/g, '-');

    // xóa phần dư - ở đầu & cuối
    s = s.replace(/^-+|-+$/g, '');
    let output = s.replace("[^A-Za-z0-9\s-]", " ")
   
    console.log(output)

    output = s.replace("\s+", " ").trim();

    // Replace all spaces with the hyphen.  
    output = s.replace("\s", "-");
    output = s.replace("\s+", " ").trim();

    // Replace all spaces with the hyphen.  

    output = s.replace(/[\u{0080}-\u{FFFF}]/gu, " ");
    
    output = s.trim().replaceAll(" ", "-");
    return output
}
handleCheckQtyCart = () => {
    $.get("/cart/CheckQtyCart", (data, err) => {
        $("#badge").html(parseInt(data.qty))
    })
}
handleHideElement = (element, opt) => {
    element.css('display', opt)
}
const handleGetProvince = (callback) => {
    $.ajax({
        type: "GET",
        beforeSend: function (request) {
            request.setRequestHeader("token", "4116bad7-d01f-11ec-ac32-0e0f5adc015a");
        },
        url: "https://online-gateway.ghn.vn/shiip/public-api/master-data/province",
        success: function (msg) {
            if (msg.data) {
                msg.data.forEach((item) => {
                    $("#province").append(`<option value="${item.ProvinceID}">${item.NameExtension[1]}</option>`)
                })
                $("#province").change((e) => {
                    handleHideElement($("#districtGroup"), 'block')
                    $("#district").html("<option disabled selected> -- Chọn Quận, Huyện -- </option>");
                    province = e.target.options[e.target.selectedIndex].text;
                    handleGetDistrict(e.target.value,callback)

                })
            }
        },
    }
    );
}
const handleGetDistrict = (province_id,callback) => {
    $.ajax({
        type: "GET",
        beforeSend: (request) => {
            request.setRequestHeader("token", "4116bad7-d01f-11ec-ac32-0e0f5adc015a");
        },
        url: "https://online-gateway.ghn.vn/shiip/public-api/master-data/district",
        data: {
            province_id: province_id
        },
        success: (res) => {
            res.data.forEach((item) => {
                $("#district").append(`<option value="${item.DistrictID}">${item.DistrictName}</option>`)
            })
            $("#district").change((e) => {
                handleHideElement($("#wardGroup"), 'block')
                $("#ward").html("<option disabled selected> -- Chọn Xã, Huyện -- </option>");
                district = e.target.options[e.target.selectedIndex].text;
                handleGetWard(e.target.value,callback)
            })
        }
    })
}
const handleGetWard = (district_id, callback) => {
    console.log({ district_id })
    $.ajax({
        type: "GET",
        beforeSend: (request) => {
            request.setRequestHeader("token", "4116bad7-d01f-11ec-ac32-0e0f5adc015a");
        },
        url: "https://online-gateway.ghn.vn/shiip/public-api/master-data/ward",
        data: {
            district_id: district_id,
        },
        success: (res) => {
            res.data.forEach((item) => {
                $("#ward").append(
                    `<option value="${item.WardCode}">${item.WardName}</option>`
                );
            });
            $("#ward").change((e) => {
                ward = e.target.options[e.target.selectedIndex].text;
                callback();
            });
        },
    });
};

if ($("#province").find(":selected").val()) {
    handleGetDistrict($("#province").find(":selected").val(),null);
    handleGetWard();
}
handleCheckQtyCart()
handleAddToCart()

