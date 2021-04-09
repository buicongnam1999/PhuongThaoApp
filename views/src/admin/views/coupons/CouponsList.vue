<template>
    <div class="coupons">
        <header-basic>Danh sách Khuyến mãi</header-basic>
        <div class="coupons-header-function">
            <input-search />
            <button-refresh />
        </div>
    </div>
</template>

<script>
import HeaderBasic from '../../components/basic/HeaderBasic.vue'
import ButtonRefresh from '../../components/basic/ButtonRefresh.vue'
import InputSearch from '../../components/basic/InputSearch.vue'
export default {
    components:{
        HeaderBasic,
        InputSearch,
        ButtonRefresh
    }
}
</script>

<style scoped>
.coupons-header-function{
    display: flex;
    margin-top: 20px;
    justify-content: space-between;
}
</style>