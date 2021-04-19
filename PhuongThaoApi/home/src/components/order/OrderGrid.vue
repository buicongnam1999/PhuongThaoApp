<template>
    <div class="order-content">
        <div class="order-content-element" v-for="order in orders" :key="order.order_id">
            <div class="product-img">
                <order-img :img="order.food_img" />
                <!-- <img src="../../assets/img/products/food/1.jpg" alt="" width="200px" height="200px"> -->
            </div>
            <div class="product-info">
                <div class="product-name">
                    <div class="product-name-text">
                        {{order.food_name}}
                    </div>
                    <div class="order-status">
                    <div v-if="order.order_status">
                            <div class="text">
                                Đang giao hàng
                            </div>
                        </div>
                        <div v-else>Đang chờ xác nhận</div>
                    </div>
                </div>
                <div class="product-price">
                    <div style="width:60px">
                        SL: {{order.quality}}
                    </div>
                    <div style="width:150px">
                        Đơn giá: {{order.food_money}}
                    </div>
                    <div style="width:200px">
                        Thành Tiền: {{order.food_money * order.quality}}
                    </div>
                </div>
                
                <div class="function-button">
                    <div>Hủy đơn hàng</div>
                </div>
            </div>
            <div >

            </div>
        </div>
        
    </div>
</template>

<script>
import axios from 'axios'
import OrderImg from './OrderImg.vue'
export default {
  components: { OrderImg },
    data() {
        return {
            orders:[]
        }
    },
    async created() {
        await axios.get("https://localhost:44344/api/order/1")
        .then(res =>  this.orders = res.data)
    },
    methods: {
        
    },
}
</script>

<style scoped>
.order-content{
    width: 80%;
    margin: 50px auto;
}
.order-content-element{
    display: flex;
    width: 100%;
}
.product-name{
    display: flex;
    width: 80%;
}
.product-img{
    width: 40%;
}
.product-info{
    width: 80%;
}
.product-name-text{
    width: 250px;
    font-size: 18px;
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
}
.text{
    margin-left: 30px;
    opacity: 0.5;
    margin-top: 8px;
}
.product-price{
    margin-top: 10px;
    display: flex;
}
.function-button{
    margin-top: 10px;
    padding: 10px 16px;
    border: none;
    outline: none;
    cursor: pointer;
    background: rgba(255, 0, 0, 0.6);
    width: 92px;
}
</style>