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
            <tr v-for="(cart,index) in carts" :key="index">
                <td class="center" colspan="1" style="width:200px">
                    <cart-img :img="cart.food_img" />
                </td>
                <td class="center" colspan="1">{{cart.food_name}}</td>
                <td class="center" colspan="1">{{cart.food_money}}</td>
                <td class="center" colspan="1">
                    <div class="product-amount">
                        <button @click="reduction(index)">-</button>
                        <input type="number" :value="cart.quality">
                        <button @click="increase(index,cart.food_id)">+</button>
                    </div>
                    
                </td>
                <td class="center" colspan="1">{{cart.food_money * cart.quality}}</td>
                <td style="width:200px">
                    <div class="function">
                        <div class="delete">
                            <button @click="Delete(cart.food_id)">Xóa</button>
                        </div>
                    </div>
                </td>
            </tr>
        </table>
        <div style="color: red; margin-top:20px; margin-left: 30px">
            Tổng tiền: {{money}}
        </div>
        <div class="function-all">
            <div class="pay">
                <button @click="PayDialog">Thanh toán</button>
            </div>
            <div class="delete">
                <button>Xóa</button>
            </div>
        </div>
        <div class="go-to-order">
            <div class="button-to-order">
                <router-link to="order">Đến đơn hàng</router-link>
            </div>
        </div>
        <pop-up-basic :isHide="isHidePop">
            <div slot="title">{{messageTitle}}</div>
            <div slot="message">{{messageContent}}</div>
            <div slot="button">
                <div class="button-pop" v-if="istrue">
                    <div class="btn-sucess" @click="Ok">Đồng ý</div>
                    <div class="btn-cancel" @click="Cancel">Hủy bỏ</div>
                </div>
                <div class="button-pop" v-else>
                    <div class="btn-sucess" @click="Pay">Đồng ý</div>
                    <div class="btn-cancel" @click="Cancel">Hủy bỏ</div>
                </div>
            </div>
        </pop-up-basic>
    </div>
</template>

<script>
import axios from 'axios'
import PopUpBasic from '../base/PopUpBasic.vue'
import CartImg from './CartImg.vue'
import swal from 'sweetalert';
export default {
  components: { PopUpBasic, CartImg},
    data() {
        return {
            carts:[],
            isHidePop: true,
            messageTitle: '',
            messageContent: '',
            id: 0,
            money : 0,
            istrue: true,
            console:{
                "error": null,
                "sucess": true,
                "data": {
                    "devMessage": null,
                    "userMessage": ""
                }
            }
        }
    },
    computed:{
        Summoney(){
            // this.money += this.money 
            return this.money
        }
    },
    methods: {
        closeDialog: function(){
            this.$emit('CloseDialog')
        },
        PayDialog(){
            this.messageTitle = "Thông báo"
            this.messageContent = "Bạn có muốn thanh toán không?" 
            this.istrue = false
            this.isHidePop = !this.isHidePop
        },
        async Pay(){
            await axios.post("https://localhost:44344/api/order/1")
            .then(res => this.console = res.data)
            .catch(ex => console.log(ex))
            if(this.console.sucess)
            {
                swal({
                        title: "Thông báo!",
                        text: "Bạn có muốn thanh toán không?",
                        icon: "success",
                        dangerMode: false,
                        })
                        .then((willDelete) => {
                        if (willDelete) {
                            location.reload()
                        }
                    });
                this.isHidePop = !this.isHidePop
            }
            
            // location.reload();
        }
        ,
        Cancel: function(){
            this.isHidePop = true
        },
        async Ok(){
            this.isHidePop = true
            await axios.delete("https://localhost:44344/api/cart/1&&"+this.id)
            .then(res => console.log(res.data))
            location.reload()
            this.id = 0
        },
        async Delete(id){
            this.messageTitle = "Thông báo"
            this.messageContent = "Bạn có muốn xóa không?"
            this.istrue = true
            this.isHidePop = !this.isHidePop
            this.id = id
        },
        reduction: function(index){
            if(this.carts[index].quality != 0){
                this.carts[index].quality --
            }
        },
        async increase(index,id){
            this.carts[index].quality ++,
            await axios.post("https://localhost:44344/api/cart/1&&"+id)
        }
    },
    async created(){
        await axios.get("https://localhost:44344/api/cart/1")
        .then(res => this.carts = res.data)
        this.carts.forEach(element => 
            this.money += element.food_money * element.quality
        )
        // console.log(this.carts)
    }
}
</script>

<style>
.cart-content{
    margin-top: 50px;
}
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
.product-amount input{
    width: 10%;
    text-align: center;
    padding: 2px 0px;
}
.product-amount button{
    outline: none;
    border: none;
    width: 30px;
    height: 25px;
    cursor: pointer;
    border-radius: 2px;
}
/* .cart-content table td img{
    border: 1px solid #e5e5e5;
    border-collapse: collapse;
} */
.function{
    display: flex;
    width: 50px;
    margin: 0px auto;
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
.go-to-order{
    margin-left: -40px;
    font: 20px;
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
}
.button-to-order{
    padding: 10px 20px;
    background: yellow;
    width: 102px;
    cursor: pointer;
    margin: 0px auto;
}
.button-to-order a{
    text-decoration: none;
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