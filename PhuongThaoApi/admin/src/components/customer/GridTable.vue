<template>
    <div class="grid">
        <table>
            <tr>
                <th class="center">STT</th>
                <th class="left">Họ và tên</th>
                <th class="center">Giới tính</th>
                <th class="left">Ngày sinh</th>
                <th class="left">Điện thoại</th>
                <th class="left">Email</th>
                <th class="right">Lương</th>
                <th class="right">Mã thẻ thành viên</th>
                <th class="right">
                    Chức năng
                </th>
            </tr>
        </table>
        <div class="table__content">
            <table>
                <tbody>
                        <tr v-for="(customer,index) in customers" :key="index">
                            <td rowspan="1" colspan="1" class="center">
                                {{index+1}}
                            </td>
                            <td rowspan="1" colspan="1" class="left">
                                {{customer.user_fullname}}
                            </td>
                            <td class="center" rowspan="1" colspan="1" v-if="customer.gender">Nam</td>
                            <td class="center" rowspan="1" colspan="1" v-else>Nữ</td>
                            <td rowspan="1" colspan="1" class="left">{{customer.user_phone}}</td>
                            <td rowspan="1" colspan="1" class="left">{{customer.user_phone}}</td>
                            <td rowspan="1" colspan="1" class="left">{{customer.user_email}}</td>
                            <td rowspan="1" colspan="1" class="right">20</td>
                            <td rowspan="1" colspan="1" class="right">0545456</td>
                            <td rowspan="1" colspan="1" class="right">
                                <div class="function">
                                    <div class="function-edit">
                                        <img src="../../assets/icon/edit.svg" alt="" srcset="">
                                    </div>
                                    <div class="function-delete">
                                        <img src="../../assets/icon/x.svg" alt="" srcset="">
                                    </div>
                                </div>
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
// import axios from "axios";
import { mapActions, mapGetters} from 'vuex'
export default {
  components: { GridPaging },
  data() {
      return {
        //   customers:[

        //   ]
      }
  },
    computed: {
        ...mapGetters("customers", {customers: "getCustomers"}),
    },
    methods: {
        ...mapActions("customers", {loadCustomers: "loadData"})
    },
    created(){
        this.loadCustomers();
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
}
.grid table tr td{
    font-size: 11px;
    height: 20px;
}
.table__content{
    overflow-y: auto;
    height: 310px;
}
.function{
    display: flex;
    justify-content: flex-end;
}
.function-edit img, .function-delete img{
    width: 20px;
    height: 20px;
    cursor: pointer;
}
.function-delete img:active, .function-edit img:active{
    opacity: 0.3;
}
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