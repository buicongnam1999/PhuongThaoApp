<template>
    <div class="grid">
        <table>
            <tr>
                <th class="center" colspan="1">STT</th>
                <th class="left" colspan="1">Mã sản phẩm</th>
                <th class="center" colspan="1">Tên sản phẩm</th>
                <th class="left" colspan="1">Kiểu sản phẩm</th>
                <th class="right" colspan="1">Số lượng</th>
                <th class="right" colspan="1">Giá</th>
                <th class="right" colspan="1">Chức năng</th>
            </tr>
        </table>
        <div class="table__content">
            <table>
                <tbody>
                        <tr v-for="(food,index) in foods" :key="food.id">
                            <td rowspan="1" colspan="1" class="center">
                                {{index+1}}
                            </td>
                            <td rowspan="1" colspan="1" class="left">
                                {{food.food_code}}
                            </td>
                            <td class="center" rowspan="1" colspan="1">{{food.food_name}}</td>
                            <td rowspan="1" colspan="1" class="left" v-if="food.food_type == 1">Bánh kẹo</td>
                            <td rowspan="1" colspan="1" class="left" v-else>Hoa quả</td>
                            <td rowspan="1" colspan="1" class="right">{{food.food_quality}}</td>
                            <td rowspan="1" colspan="1" class="right">{{food.food_money}}</td>
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
        <product-paging />
    </div>
</template>

<script>
import ProductPaging from './ProductPaging.vue'
import { mapActions, mapGetters} from 'vuex'
export default {
  components: { ProductPaging },
  data(){
      return{

      }
  },
    computed: {
        ...mapGetters("foods", {foods: "getFoods"}),
    },
    methods: {
        ...mapActions("foods", {loadFoods: "loadData"})
    },
    created(){
        this.loadFoods();
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