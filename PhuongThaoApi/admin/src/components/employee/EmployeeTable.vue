<template>
    <div class="grid">
        <table>
            <tr>
                <th class="center">STT</th>
                <th class="left">Họ và tên</th>
                <th class="center">Giới tính</th>
                <th class="left">Ngày sinh</th>
                <th class="left">Điện thoại</th>
                <th class="left" colspan="2">Email</th>
                <th class="left">Tài khoản</th>
                <th class="right">Chức năng</th>
            </tr>
        </table>
        <div class="table__content">
            <table>
                <tbody>
                    <tr v-for="(employee,index) in employees" :key="index">
                        <td rowspan="1" colspan="1" class="center">
                            {{index+1}}
                        </td>
                        <td rowspan="1" colspan="1" class="left">
                            {{employee.user_fullname}}
                        </td>
                        <td class="center" rowspan="1" colspan="1" v-if="employee.user_gender">Nam</td>
                        <td class="center" rowspan="1" colspan="1" v-else>Nữ</td>
                        <td rowspan="1" colspan="1" class="left">20-09-1999</td>
                        <td rowspan="1" colspan="1" class="left">{{employee.user_phone}}</td>
                        <td rowspan="1" colspan="2" class="left">{{employee.user_email}}</td>
                        <td rowspan="1" colspan="1" class="left">{{employee.u_name}}</td>
                        <td rowspan="1" colspan="1" class="right">
                            <div class="function">
                                <div class="function-edit" @click="openForm(employee.u_id)">
                                    <img src="../../assets/icon/edit.svg" alt="" srcset="">
                                </div>
                                <div class="function-delete" @click="deleteEmployee(employee.u_id, index)">
                                    <img src="../../assets/icon/x.svg" alt="" srcset="">
                                </div>
                            </div>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <grid-paging />
        <dialog-employee :isHide="isHide" :employee="employeeEdit" @closeForm="closeForm" v-on:addObject="addObject($e)"/>
        <pop-up-basic :isHide="isHidePop">
            <div slot="title">Thông báo</div>
            <div slot="message"><i class="fa fa-exclamation-triangle" aria-hidden="true"></i>Bạn có muốn xóa không?</div>
            <div slot="button">
                <div class="button">
                    <div class="btn-sucess" @click="Ok">Đồng ý</div>
                    <div class="btn-cancel" @click="Cancel">Hủy bỏ</div>
                </div>
            </div>
        </pop-up-basic>
    </div>
</template>

<script>
import DialogEmployee from './DialogEmployee.vue'
import GridPaging from './GridPaging.vue'
import axios from 'axios'
import PopUpBasic from '../basic/PopUpBasic.vue'
import { mapActions, mapGetters} from 'vuex'
export default {
  components: { 
        GridPaging,
        DialogEmployee,
        PopUpBasic,
    },
    data() {
        return {
            isHide: true,
            isHidePop: true,
            sucess: false,
            index: -1,
            isHideEdit: true,
            id : 0,
            employeeEdit:{

            }
        }
    },
    computed:{
        ...mapGetters("employees", {employees: "getEmployees"},{employee: "getEmployeeEdit"}),
    },
    async created(){
        this.loadEmployees();
    },
    methods: {
        async openForm(id) {
            // await axios.get("https://localhost:44344/api/user/"+id)
            // .then( res => this.employeeEdit = res.data)
            // this.isHide = !this.isHide
            // console.log(this.employeeEdit.u_id)

            this.$store.dispatch("employees/getEmployeeById",id);
            // this.loadEmployeeById();
            console.log(this.employee);
            this.isHide = !this.isHide
        },
        closeForm: function() {
            this.isHide = true
            this.isHideEdit = true
        },
        Cancel: function(){
            this.isHidePop =!this.isHidePop
        },
        async Ok(){
            this.sucess = !this.sucess
            if(this.sucess){
                await axios.delete("https://localhost:44344/api/user/" + this.id)
                .then(response => 
                        console.log(response.data)
                    )
                .catch(error => alert(error));
                
                this.sucess = !this.sucess
            }
            this.employees.splice(this.index,1)
            this.isHidePop =!this.isHidePop
            this.index = -1
            this.id = 0;
        },
        deleteEmployee(id,index){
            this.id = id
            this.index = index
            this.isHidePop = !this.isHidePop
        },
        addObject: function(e){
            e === 'abc' ? true: false
            this.isHide = e
            // alert(e.user_fullname)
        },
        ...mapActions("employees", {loadEmployees: "loadData"},{loadEmployeeById: "getEmployeeById"})

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