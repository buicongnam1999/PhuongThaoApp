<template>
    <div class="cart-content">
        <table>
            <tr>
                <th colspan="1">Hình Ảnh</th>
                <th colspan="1">Tên sản phẩm</th>
                <th colspan="1">Giá</th>
                <th colspan="1">Số lượng</th>
                <th colspan="1">Tổng tiền</th>
                <th colspan="1">Chức năng</th>
            </tr>
            <tr>
                <td class="center" colspan="1" style="width:200px">
                    <img src="../../assets/img/products/food/1.jpg" alt="" srcset="" width="100px" height="100px">
                </td>
                <td class="center" colspan="1">Hambeger</td>
                <td class="center" colspan="1">25.000</td>
                <td class="center" colspan="1">
                    1
                </td>
                <td class="center" colspan="1">25.000</td>
                <td style="width:200px">
                    <div class="function">
                        <div class="pay">
                            <button>Thanh toán</button>
                        </div>
                        <div class="delete">
                            <button>Xóa</button>
                        </div>
                    </div>
                </td>
            </tr>
        </table>
        <div class="function-all">
            <div class="pay">
                <button>Thanh toán</button>
            </div>
            <div class="delete">
                <button>Xóa</button>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    
}
</script>

<style>
.cart-content table, th, td{
    border: 1px solid #e5e5e5;
    border-collapse: collapse;
}
.cart-content table{
    width: 95%;
    margin: 0 auto;
}
.cart-content table th{
    height: 40px;
}
.cart-content table td{
    height: 120px;
}
/* .cart-content table td img{
    border: 1px solid #e5e5e5;
    border-collapse: collapse;
} */
.function{
    display: flex;
    width: 50px;
    margin-left: 18px;
}
.pay button, .delete button{
    padding: 10px 16px;
    border: none;
    outline: none;
    cursor: pointer;
}
.pay button{
    background: rgba(52, 210, 138, 1);
    width: 100px;
}
.delete button{
    margin-left: 5px;
    background: rgba(255, 0, 0, 0.8);
}
.function-all{
    width: 0%;
    display: flex;
    margin: 25px calc(50% - 100px);
}
.center{
    text-align: center;
}
.left{
    text-align:  left;
}
.right{
    text-align: right;
}
</style>