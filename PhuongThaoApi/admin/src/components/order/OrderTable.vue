<template>
    <div class="grid">
        <table>
            <tr>
                <th class="center" colspan="1">STT</th>
                <th class="left" colspan="1">Mã đơn hàng</th>
                <th class="center" colspan="1">Khách hàng</th>
                <th class="left" colspan="1">Ngày Thanh toán</th>
                <th class="left" colspan="1">Số điện thoại</th>
                <th class="left" colspan="1">Tổng tiền</th>
                <th class="right" colspan="2">Chức năng</th>
            </tr>
        </table>
        <div class="table__content">
            <table>
                <tbody>
                    <tr v-for="(order,index) in ordersTable" :key="index">
                        <td rowspan="1" colspan="1" class="center">
                            {{index+1}}
                        </td>
                        <td rowspan="1" colspan="1" class="left">
                            {{order.order_id}}
                        </td>
                        <td class="center" rowspan="1" colspan="1">{{order.user_fullname}}</td>
                        <td rowspan="1" colspan="1" class="left">{{order.order_date}}</td>
                        <td rowspan="1" colspan="1" class="left">{{order.user_phone}}</td>
                        <td rowspan="1" colspan="1" class="left">{{order.food_money}}</td>
                        <td rowspan="1" colspan="2" class="right" v-if="order.user_gender">
                            <div class="function">
                                <div class="btn-confirm">Xác nhận</div>
                                <div class="btn-cancel">Hủy đơn hàng</div>
                            </div>
                        </td>
                        <td class="right" v-else>
                            <div style="color: rgba(128,128,128,0.8)"><i>Đã xác thực</i></div>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <grid-paging />
    </div>
</template>

<script>
import GridPaging from './GridPaging.vue'
import { mapActions, mapGetters} from 'vuex'
import axios from "axios";
export default {
  components: { 
        GridPaging,
    },
    data() {
        return {
            isHide: true,
            sucess: false,
            index: -1,
            isHideEdit: true,
            id : 0,
            ordersTable:[

            ]
        }
    },
    computed:{
        ...mapGetters("orders", {orders: "getOrders"}),
    },
    async created(){
        this.ordersTable = await axios.get("https://localhost:44344/api/order").then(res => this.ordersTable = res.data) 
        this.ordersTable.forEach(element => {
            var m = new Date(element.order_date);
            
            var dateString =
                m.getUTCFullYear() + "-" +
                ("0" + (m.getUTCMonth()+1)).slice(-2) + "-" +
                ("0" + m.getUTCDate()).slice(-2) + " " +
                ("0" + m.getUTCHours()).slice(-2) + ":" +
                ("0" + m.getUTCMinutes()).slice(-2) + ":" +
                ("0" + m.getUTCSeconds()).slice(-2)
                element.order_date = dateString

            var money = element.quality * element.food_money
            if (money) {
                    money =  money.toFixed(0).replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1.");
                } else {
                    money = 0;  
                }
                element.food_money = money;
        })
    },
    methods: {
        ...mapActions("orders", {loadOrders: "loadData"})
    },
    

}
</script>

<style scoped>
.grid{
    margin-top: 30px;
}
.grid table{
    width: 100%;
    table-layout: fixed;
}
.grid table tr th{
    font-size: 12px;
    width: 100px;
}
.grid table tr td{
    font-size: 11px;
    width: 100px;
    height: 20px;
}
.function{
    display: flex;
    justify-content: flex-end;
}
.btn-confirm,.btn-cancel{
    padding: 8px 15px;
    color: white;
    cursor: pointer;
    border-radius: 3px;
}
.btn-confirm{
    background: rgba(0,128,0, 0.8);
    margin-right: 10px;
}
.btn-cancel{
    background: red;
}
.table__content{
    overflow-y: auto;
    height: 310px;
}
/* .button{
    display: flex;
} */
.center{
    text-align: center;
}
.right{
    text-align: right;
}
.left{
    text-align: left;
}
</style>